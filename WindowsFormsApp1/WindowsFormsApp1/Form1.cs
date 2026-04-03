using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private enum OrderStatus { New, Active, Completed }

        private class Order
        {
            public int Id { get; set; }
            public string Customer { get; set; }
            public string Item { get; set; }
            public DateTime Date { get; set; }
            public OrderStatus Status { get; set; }
        }

        private List<Order> orders = new List<Order>();
        private int nextId = 1;

        public Form1()
        {
            InitializeComponent();
            InitializeLists();
        }

        private void InitializeLists()
        {
            // nothing to do here for now, lists are configured in designer
        }

        private void RefreshLists()
        {
            listViewNew.Items.Clear();
            listViewActive.Items.Clear();
            listViewCompleted.Items.Clear();

            foreach (var o in orders)
            {
                var arr = new[] { o.Id.ToString(), o.Customer, o.Item, o.Date.ToString("g") };
                var item = new ListViewItem(arr);
                item.Tag = o;
                switch (o.Status)
                {
                    case OrderStatus.New:
                        listViewNew.Items.Add(item);
                        break;
                    case OrderStatus.Active:
                        listViewActive.Items.Add(item);
                        break;
                    case OrderStatus.Completed:
                        listViewCompleted.Items.Add(item);
                        break;
                }
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            var customer = txtCustomer.Text.Trim();
            var item = txtItem.Text.Trim();
            if (string.IsNullOrEmpty(customer) || string.IsNullOrEmpty(item))
            {
                MessageBox.Show("Customer and Item are required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var o = new Order
            {
                Id = nextId++,
                Customer = customer,
                Item = item,
                Date = DateTime.Now,
                Status = OrderStatus.New
            };
            orders.Add(o);

            txtCustomer.Clear();
            txtItem.Clear();

            RefreshLists();
        }

        private void btnMoveToActive_Click(object sender, EventArgs e)
        {
            if (listViewNew.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select a new order to move to active.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var o = listViewNew.SelectedItems[0].Tag as Order;
            if (o != null)
            {
                o.Status = OrderStatus.Active;
                RefreshLists();
            }
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (listViewActive.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select an active order to mark completed.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var o = listViewActive.SelectedItems[0].Tag as Order;
            if (o != null)
            {
                o.Status = OrderStatus.Completed;
                RefreshLists();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listViewCompleted.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select a completed order to delete.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var o = listViewCompleted.SelectedItems[0].Tag as Order;
            if (o != null)
            {
                orders.Remove(o);
                RefreshLists();
            }
        }
    }
}
