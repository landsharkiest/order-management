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
            public decimal OrderValue { get; set; }
            public DateTime DueDate { get; set; }
        }

        private List<Order> orders = new List<Order>();
        private int nextId = 1;

        public Form1()
        {
            InitializeComponent();
            InitializeLists();
            SetupContextMenus();
        }

        private void SetupContextMenus()
        {
            var cmNew = new ContextMenuStrip();
            cmNew.Items.Add("Move to Active", null, (s, e) => MoveFromNewToActive());
            listViewNew.ContextMenuStrip = cmNew;

            var cmActive = new ContextMenuStrip();
            cmActive.Items.Add("Move to New", null, (s, e) => MoveFromActiveToNew());
            cmActive.Items.Add("Mark Completed", null, (s, e) => MoveFromActiveToCompleted());
            listViewActive.ContextMenuStrip = cmActive;

            var cmCompleted = new ContextMenuStrip();
            cmCompleted.Items.Add("Move to Active", null, (s, e) => MoveFromCompletedToActive());
            cmCompleted.Items.Add("Delete", null, (s, e) => DeleteFromCompleted());
            listViewCompleted.ContextMenuStrip = cmCompleted;
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
                var arr = new[] 
                { 
                    o.Id.ToString(), 
                    o.Customer, 
                    o.Item,
                    o.OrderValue.ToString("C"),
                    o.DueDate.ToString("d"),
                    o.Date.ToString("g") 
                };
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

            if (!decimal.TryParse(txtOrderValue.Text.Trim(), out decimal orderValue))
            {
                MessageBox.Show("Order Value must be a valid number.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var o = new Order
            {
                Id = nextId++,
                Customer = customer,
                Item = item,
                Date = DateTime.Now,
                Status = OrderStatus.New,
                OrderValue = orderValue,
                DueDate = dtpDueDate.Value
            };
            orders.Add(o);

            txtCustomer.Clear();
            txtItem.Clear();
            txtOrderValue.Clear();
            dtpDueDate.Value = DateTime.Now;

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

        private void MoveFromNewToActive()
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

        private void MoveFromActiveToNew()
        {
            if (listViewActive.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select an active order to move to new.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var o = listViewActive.SelectedItems[0].Tag as Order;
            if (o != null)
            {
                o.Status = OrderStatus.New;
                RefreshLists();
            }
        }

        private void MoveFromActiveToCompleted()
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

        private void MoveFromCompletedToActive()
        {
            if (listViewCompleted.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select a completed order to move to active.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var o = listViewCompleted.SelectedItems[0].Tag as Order;
            if (o != null)
            {
                o.Status = OrderStatus.Active;
                RefreshLists();
            }
        }

        private void DeleteFromCompleted()
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
