namespace WindowsFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageNew;
        private System.Windows.Forms.TabPage tabPageActive;
        private System.Windows.Forms.TabPage tabPageCompleted;
        private System.Windows.Forms.ListView listViewNew;
        private System.Windows.Forms.ListView listViewActive;
        private System.Windows.Forms.ListView listViewCompleted;
        private System.Windows.Forms.ColumnHeader columnHeaderId1;
        private System.Windows.Forms.ColumnHeader columnHeaderCustomer1;
        private System.Windows.Forms.ColumnHeader columnHeaderItem1;
        private System.Windows.Forms.ColumnHeader columnHeaderDate1;
        private System.Windows.Forms.ColumnHeader columnHeaderId2;
        private System.Windows.Forms.ColumnHeader columnHeaderCustomer2;
        private System.Windows.Forms.ColumnHeader columnHeaderItem2;
        private System.Windows.Forms.ColumnHeader columnHeaderDate2;
        private System.Windows.Forms.ColumnHeader columnHeaderId3;
        private System.Windows.Forms.ColumnHeader columnHeaderCustomer3;
        private System.Windows.Forms.ColumnHeader columnHeaderItem3;
        private System.Windows.Forms.ColumnHeader columnHeaderDate3;
        private System.Windows.Forms.Panel panelNew;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnMoveToActive;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtOrderValue;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Label lblOrderValue;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.ColumnHeader columnHeaderValue1;
        private System.Windows.Forms.ColumnHeader columnHeaderValue2;
        private System.Windows.Forms.ColumnHeader columnHeaderValue3;
        private System.Windows.Forms.ColumnHeader columnHeaderDueDate1;
        private System.Windows.Forms.ColumnHeader columnHeaderDueDate2;
        private System.Windows.Forms.ColumnHeader columnHeaderDueDate3;

        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageNew = new System.Windows.Forms.TabPage();
            this.tabPageActive = new System.Windows.Forms.TabPage();
            this.tabPageCompleted = new System.Windows.Forms.TabPage();
            this.listViewNew = new System.Windows.Forms.ListView();
            this.listViewActive = new System.Windows.Forms.ListView();
            this.listViewCompleted = new System.Windows.Forms.ListView();
            this.columnHeaderId1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCustomer1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderItem1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDate1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderId2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCustomer2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderItem2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDate2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderId3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCustomer3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderItem3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDate3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelNew = new System.Windows.Forms.Panel();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnMoveToActive = new System.Windows.Forms.Button();
            this.btnComplete = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtOrderValue = new System.Windows.Forms.TextBox();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.lblOrderValue = new System.Windows.Forms.Label();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.columnHeaderValue1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderValue2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderValue3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDueDate1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDueDate2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDueDate3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Controls.Add(this.tabPageNew);
            this.tabControlMain.Controls.Add(this.tabPageActive);
            this.tabControlMain.Controls.Add(this.tabPageCompleted);
            this.tabControlMain.Location = new System.Drawing.Point(12, 12);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(776, 426);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageNew
            // 
            this.tabPageNew.Controls.Add(this.listViewNew);
            this.tabPageNew.Controls.Add(this.panelNew);
            this.tabPageNew.Location = new System.Drawing.Point(4, 22);
            this.tabPageNew.Name = "tabPageNew";
            this.tabPageNew.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNew.Size = new System.Drawing.Size(768, 400);
            this.tabPageNew.TabIndex = 0;
            this.tabPageNew.Text = "New Orders";
            this.tabPageNew.UseVisualStyleBackColor = true;
            // 
            // tabPageActive
            // 
            this.tabPageActive.Controls.Add(this.listViewActive);
            this.tabPageActive.Controls.Add(this.btnComplete);
            this.tabPageActive.Location = new System.Drawing.Point(4, 22);
            this.tabPageActive.Name = "tabPageActive";
            this.tabPageActive.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageActive.Size = new System.Drawing.Size(768, 400);
            this.tabPageActive.TabIndex = 1;
            this.tabPageActive.Text = "Active Orders";
            this.tabPageActive.UseVisualStyleBackColor = true;
            // 
            // tabPageCompleted
            // 
            this.tabPageCompleted.Controls.Add(this.listViewCompleted);
            this.tabPageCompleted.Controls.Add(this.btnDelete);
            this.tabPageCompleted.Location = new System.Drawing.Point(4, 22);
            this.tabPageCompleted.Name = "tabPageCompleted";
            this.tabPageCompleted.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCompleted.Size = new System.Drawing.Size(768, 400);
            this.tabPageCompleted.TabIndex = 2;
            this.tabPageCompleted.Text = "Completed Orders";
            this.tabPageCompleted.UseVisualStyleBackColor = true;
            // 
            // listViewNew
            // 
            this.listViewNew.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewNew.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderId1,
            this.columnHeaderCustomer1,
            this.columnHeaderItem1,
            this.columnHeaderValue1,
            this.columnHeaderDueDate1,
            this.columnHeaderDate1});
            this.listViewNew.FullRowSelect = true;
            this.listViewNew.HideSelection = false;
            this.listViewNew.Location = new System.Drawing.Point(6, 6);
            this.listViewNew.MultiSelect = false;
            this.listViewNew.Name = "listViewNew";
            this.listViewNew.Size = new System.Drawing.Size(756, 300);
            this.listViewNew.TabIndex = 0;
            this.listViewNew.UseCompatibleStateImageBehavior = false;
            this.listViewNew.View = System.Windows.Forms.View.Details;
            // 
            // listViewActive
            // 
            this.listViewActive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewActive.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderId2,
            this.columnHeaderCustomer2,
            this.columnHeaderItem2,
            this.columnHeaderValue2,
            this.columnHeaderDueDate2,
            this.columnHeaderDate2});
            this.listViewActive.FullRowSelect = true;
            this.listViewActive.HideSelection = false;
            this.listViewActive.Location = new System.Drawing.Point(6, 6);
            this.listViewActive.MultiSelect = false;
            this.listViewActive.Name = "listViewActive";
            this.listViewActive.Size = new System.Drawing.Size(756, 340);
            this.listViewActive.TabIndex = 0;
            this.listViewActive.UseCompatibleStateImageBehavior = false;
            this.listViewActive.View = System.Windows.Forms.View.Details;
            // 
            // listViewCompleted
            // 
            this.listViewCompleted.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewCompleted.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderId3,
            this.columnHeaderCustomer3,
            this.columnHeaderItem3,
            this.columnHeaderValue3,
            this.columnHeaderDueDate3,
            this.columnHeaderDate3});
            this.listViewCompleted.FullRowSelect = true;
            this.listViewCompleted.HideSelection = false;
            this.listViewCompleted.Location = new System.Drawing.Point(6, 6);
            this.listViewCompleted.MultiSelect = false;
            this.listViewCompleted.Name = "listViewCompleted";
            this.listViewCompleted.Size = new System.Drawing.Size(756, 340);
            this.listViewCompleted.TabIndex = 0;
            this.listViewCompleted.UseCompatibleStateImageBehavior = false;
            this.listViewCompleted.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderId1
            // 
            this.columnHeaderId1.Text = "ID";
            this.columnHeaderId1.Width = 40;
            // 
            // columnHeaderCustomer1
            // 
            this.columnHeaderCustomer1.Text = "Customer";
            this.columnHeaderCustomer1.Width = 200;
            // 
            // columnHeaderItem1
            // 
            this.columnHeaderItem1.Text = "Item";
            this.columnHeaderItem1.Width = 300;
            // 
            // columnHeaderDate1
            // 
            this.columnHeaderDate1.Text = "Date";
            this.columnHeaderDate1.Width = 100;
            // 
            // columnHeaderValue1
            // 
            this.columnHeaderValue1.Text = "Order Value";
            this.columnHeaderValue1.Width = 100;
            // 
            // columnHeaderDueDate1
            // 
            this.columnHeaderDueDate1.Text = "Due Date";
            this.columnHeaderDueDate1.Width = 100;
            // 
            // columnHeaderId2
            // 
            this.columnHeaderId2.Text = "ID";
            this.columnHeaderId2.Width = 40;
            // 
            // columnHeaderCustomer2
            // 
            this.columnHeaderCustomer2.Text = "Customer";
            this.columnHeaderCustomer2.Width = 200;
            // 
            // columnHeaderItem2
            // 
            this.columnHeaderItem2.Text = "Item";
            this.columnHeaderItem2.Width = 300;
            // 
            // columnHeaderDate2
            // 
            this.columnHeaderDate2.Text = "Date";
            this.columnHeaderDate2.Width = 100;
            // 
            // columnHeaderValue2
            // 
            this.columnHeaderValue2.Text = "Order Value";
            this.columnHeaderValue2.Width = 100;
            // 
            // columnHeaderDueDate2
            // 
            this.columnHeaderDueDate2.Text = "Due Date";
            this.columnHeaderDueDate2.Width = 100;
            // 
            // columnHeaderId3
            // 
            this.columnHeaderId3.Text = "ID";
            this.columnHeaderId3.Width = 40;
            // 
            // columnHeaderCustomer3
            // 
            this.columnHeaderCustomer3.Text = "Customer";
            this.columnHeaderCustomer3.Width = 200;
            // 
            // columnHeaderItem3
            // 
            this.columnHeaderItem3.Text = "Item";
            this.columnHeaderItem3.Width = 300;
            // 
            // columnHeaderDate3
            // 
            this.columnHeaderDate3.Text = "Date";
            this.columnHeaderDate3.Width = 100;
            // 
            // columnHeaderValue3
            // 
            this.columnHeaderValue3.Text = "Order Value";
            this.columnHeaderValue3.Width = 100;
            // 
            // columnHeaderDueDate3
            // 
            this.columnHeaderDueDate3.Text = "Due Date";
            this.columnHeaderDueDate3.Width = 100;
            // 
            // panelNew
            // 
            this.panelNew.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelNew.Controls.Add(this.txtItem);
            this.panelNew.Controls.Add(this.txtCustomer);
            this.panelNew.Controls.Add(this.txtOrderValue);
            this.panelNew.Controls.Add(this.dtpDueDate);
            this.panelNew.Controls.Add(this.lblItem);
            this.panelNew.Controls.Add(this.lblCustomer);
            this.panelNew.Controls.Add(this.lblOrderValue);
            this.panelNew.Controls.Add(this.lblDueDate);
            this.panelNew.Controls.Add(this.btnAddNew);
            this.panelNew.Controls.Add(this.btnMoveToActive);
            this.panelNew.Location = new System.Drawing.Point(6, 312);
            this.panelNew.Name = "panelNew";
            this.panelNew.Size = new System.Drawing.Size(756, 82);
            this.panelNew.TabIndex = 1;
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(320, 10);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(150, 20);
            this.txtItem.TabIndex = 3;
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(80, 10);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(150, 20);
            this.txtCustomer.TabIndex = 2;
            // 
            // txtOrderValue
            // 
            this.txtOrderValue.Location = new System.Drawing.Point(80, 40);
            this.txtOrderValue.Name = "txtOrderValue";
            this.txtOrderValue.Size = new System.Drawing.Size(150, 20);
            this.txtOrderValue.TabIndex = 4;
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Location = new System.Drawing.Point(320, 40);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(150, 20);
            this.dtpDueDate.TabIndex = 5;
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(286, 13);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(28, 13);
            this.lblItem.TabIndex = 4;
            this.lblItem.Text = "Item";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(18, 13);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(56, 13);
            this.lblCustomer.TabIndex = 3;
            this.lblCustomer.Text = "Customer";
            // 
            // lblOrderValue
            // 
            this.lblOrderValue.AutoSize = true;
            this.lblOrderValue.Location = new System.Drawing.Point(10, 43);
            this.lblOrderValue.Name = "lblOrderValue";
            this.lblOrderValue.Size = new System.Drawing.Size(64, 13);
            this.lblOrderValue.TabIndex = 5;
            this.lblOrderValue.Text = "Order Value";
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Location = new System.Drawing.Point(250, 43);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(56, 13);
            this.lblDueDate.TabIndex = 6;
            this.lblDueDate.Text = "Due Date";
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(540, 8);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(100, 23);
            this.btnAddNew.TabIndex = 6;
            this.btnAddNew.Text = "Add Order";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnMoveToActive
            // 
            this.btnMoveToActive.Location = new System.Drawing.Point(540, 40);
            this.btnMoveToActive.Name = "btnMoveToActive";
            this.btnMoveToActive.Size = new System.Drawing.Size(100, 23);
            this.btnMoveToActive.TabIndex = 7;
            this.btnMoveToActive.Text = "Move to Active";
            this.btnMoveToActive.UseVisualStyleBackColor = true;
            this.btnMoveToActive.Click += new System.EventHandler(this.btnMoveToActive_Click);
            // 
            // btnComplete
            // 
            this.btnComplete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnComplete.Location = new System.Drawing.Point(662, 352);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(100, 23);
            this.btnComplete.TabIndex = 1;
            this.btnComplete.Text = "Mark Completed";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(662, 352);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlMain);
            this.Name = "Form1";
            this.Text = "Orders Dashboard";
            this.tabControlMain.ResumeLayout(false);
            this.tabPageNew.ResumeLayout(false);
            this.panelNew.ResumeLayout(false);
            this.panelNew.PerformLayout();
            this.tabPageActive.ResumeLayout(false);
            this.tabPageCompleted.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion
    }
}

