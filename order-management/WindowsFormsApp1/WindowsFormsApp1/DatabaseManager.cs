using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using Microsoft.Data.Sqlite;

namespace WindowsFormsApp1
{
    public static class DatabaseManager
    {
        [DllImport("kernel32", SetLastError = true, CharSet = CharSet.Unicode)]
        private static extern bool SetDllDirectory(string lpPathName);

        private static bool _sqliteInitialized;

        private static string _dbPath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "OrderManagement",
            "OrderManagementDB.db"
        );

        private static string ConnectionString => $"Data Source={_dbPath};";

        private static void EnsureSqliteRuntime()
        {
            if (_sqliteInitialized)
                return;

            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string packagesRoot = Path.GetFullPath(Path.Combine(baseDir, "..", "..", "..", "packages"));

            string nativeFolder = Environment.Is64BitProcess
                ? Path.Combine(packagesRoot, "SQLitePCLRaw.lib.e_sqlite3.2.1.11", "runtimes", "win-x64", "native")
                : Path.Combine(packagesRoot, "SQLitePCLRaw.lib.e_sqlite3.2.1.11", "runtimes", "win-x86", "native");

            string providerDll = Path.Combine(packagesRoot, "SQLitePCLRaw.provider.e_sqlite3.2.1.11", "lib", "netstandard2.0", "SQLitePCLRaw.provider.e_sqlite3.dll");

            if (!Directory.Exists(nativeFolder) || !File.Exists(providerDll))
            {
                throw new InvalidOperationException("SQLite runtime files are missing. Restore SQLitePCLRaw packages before starting the app.");
            }

            SetDllDirectory(nativeFolder);
            Assembly providerAssembly = Assembly.LoadFrom(providerDll);

            Type providerType = providerAssembly.GetType("SQLitePCL.SQLite3Provider_e_sqlite3", throwOnError: true);
            object providerInstance = Activator.CreateInstance(providerType);

            Type rawType = Type.GetType("SQLitePCL.raw, SQLitePCLRaw.core", throwOnError: false);
            if (rawType == null)
            {
                foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
                {
                    if (assembly.GetName().Name == "SQLitePCLRaw.core")
                    {
                        rawType = assembly.GetType("SQLitePCL.raw", throwOnError: false);
                        if (rawType != null)
                            break;
                    }
                }
            }

            if (rawType == null)
                throw new InvalidOperationException("Could not find SQLitePCL.raw type from loaded SQLitePCLRaw.core assembly.");

            MethodInfo setProviderMethod = rawType.GetMethod("SetProvider", BindingFlags.Public | BindingFlags.Static);
            if (setProviderMethod == null)
                throw new InvalidOperationException("Could not find SQLitePCL.raw.SetProvider method.");

            var setProviderParams = setProviderMethod.GetParameters();
            if (setProviderParams.Length == 1)
                setProviderMethod.Invoke(null, new object[] { providerInstance });
            else
                throw new InvalidOperationException("Unexpected SetProvider signature.");

            MethodInfo freezeProviderMethod = rawType.GetMethod("FreezeProvider", BindingFlags.Public | BindingFlags.Static);
            if (freezeProviderMethod != null)
            {
                var freezeParams = freezeProviderMethod.GetParameters();
                if (freezeParams.Length == 0)
                    freezeProviderMethod.Invoke(null, null);
                else if (freezeParams.Length == 1)
                    freezeProviderMethod.Invoke(null, new object[] { true });
                else
                    throw new InvalidOperationException("Unexpected FreezeProvider signature.");
            }

            _sqliteInitialized = true;
        }

        internal static void SetDatabasePath(string path)
        {
            _dbPath = path;
        }

        public static void InitializeDatabase()
        {
            EnsureSqliteRuntime();

            string dir = Path.GetDirectoryName(_dbPath);
            if (!string.IsNullOrEmpty(dir) && !Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            using (var connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();

                string sql = @"
                    CREATE TABLE IF NOT EXISTS Orders (
                        Id         INTEGER PRIMARY KEY AUTOINCREMENT,
                        Customer   TEXT    NOT NULL,
                        Item       TEXT    NOT NULL,
                        OrderValue REAL    NOT NULL,
                        DueDate    TEXT    NOT NULL,
                        Date       TEXT    NOT NULL,
                        Status     INTEGER NOT NULL
                    )";

                using (var cmd = new SqliteCommand(sql, connection))
                    cmd.ExecuteNonQuery();
            }
        }

        public static void AddOrder(string customer, string item, decimal orderValue, DateTime dueDate, int status)
        {
            using (var connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();

                string sql = @"
                    INSERT INTO Orders (Customer, Item, OrderValue, DueDate, Date, Status)
                    VALUES (@Customer, @Item, @OrderValue, @DueDate, @Date, @Status)";

                using (var cmd = new SqliteCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@Customer", customer);
                    cmd.Parameters.AddWithValue("@Item", item);
                    cmd.Parameters.AddWithValue("@OrderValue", (double)orderValue);
                    cmd.Parameters.AddWithValue("@DueDate", dueDate.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@Date", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<(int Id, string Customer, string Item, DateTime Date, int Status, decimal OrderValue, DateTime DueDate)> GetAllOrders()
        {
            var orders = new List<(int, string, string, DateTime, int, decimal, DateTime)>();

            using (var connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();

                string sql = "SELECT Id, Customer, Item, Date, Status, OrderValue, DueDate FROM Orders ORDER BY Id";

                using (var cmd = new SqliteCommand(sql, connection))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["Id"]);
                        string customer = reader["Customer"].ToString();
                        string item = reader["Item"].ToString();
                        DateTime date = DateTime.Parse(reader["Date"].ToString());
                        int status = Convert.ToInt32(reader["Status"]);
                        decimal orderValue = Convert.ToDecimal(reader["OrderValue"]);
                        DateTime dueDate = DateTime.Parse(reader["DueDate"].ToString());

                        orders.Add((id, customer, item, date, status, orderValue, dueDate));
                    }
                }
            }

            return orders;
        }

        public static void UpdateOrderStatus(int id, int status)
        {
            using (var connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();

                string sql = "UPDATE Orders SET Status = @Status WHERE Id = @Id";

                using (var cmd = new SqliteCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void DeleteOrder(int id)
        {
            using (var connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();

                string sql = "DELETE FROM Orders WHERE Id = @Id";

                using (var cmd = new SqliteCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}

