namespace SalesManagement
{
    partial class SalesCtrl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.salesListPanel = new System.Windows.Forms.Panel();
            this.dgSalesItemList = new System.Windows.Forms.DataGridView();
            this.itemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbItem = new System.Windows.Forms.ComboBox();
            this.lblItem = new System.Windows.Forms.Label();
            this.txtItemQuantity = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnGenerateBill = new System.Windows.Forms.Button();
            this.salesListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSalesItemList)).BeginInit();
            this.SuspendLayout();
            // 
            // salesListPanel
            // 
            this.salesListPanel.Controls.Add(this.dgSalesItemList);
            this.salesListPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.salesListPanel.Location = new System.Drawing.Point(0, 370);
            this.salesListPanel.Name = "salesListPanel";
            this.salesListPanel.Size = new System.Drawing.Size(1050, 210);
            this.salesListPanel.TabIndex = 0;
            // 
            // dgSalesItemList
            // 
            this.dgSalesItemList.AllowUserToAddRows = false;
            this.dgSalesItemList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgSalesItemList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgSalesItemList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgSalesItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSalesItemList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemID,
            this.serialNo,
            this.itemName,
            this.itemPrice,
            this.itemQuantity,
            this.itemTotal,
            this.itemDiscount});
            this.dgSalesItemList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgSalesItemList.Location = new System.Drawing.Point(0, 0);
            this.dgSalesItemList.Name = "dgSalesItemList";
            this.dgSalesItemList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgSalesItemList.RowHeadersVisible = false;
            this.dgSalesItemList.RowTemplate.Height = 28;
            this.dgSalesItemList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgSalesItemList.Size = new System.Drawing.Size(1050, 210);
            this.dgSalesItemList.TabIndex = 8;
            // 
            // itemID
            // 
            this.itemID.HeaderText = "ID";
            this.itemID.Name = "itemID";
            this.itemID.Visible = false;
            // 
            // serialNo
            // 
            this.serialNo.HeaderText = "SN";
            this.serialNo.Name = "serialNo";
            // 
            // itemName
            // 
            this.itemName.HeaderText = "Item Name";
            this.itemName.Name = "itemName";
            // 
            // itemPrice
            // 
            this.itemPrice.HeaderText = "Price";
            this.itemPrice.Name = "itemPrice";
            // 
            // itemQuantity
            // 
            this.itemQuantity.HeaderText = "Quantity";
            this.itemQuantity.Name = "itemQuantity";
            // 
            // itemTotal
            // 
            this.itemTotal.HeaderText = "Total";
            this.itemTotal.Name = "itemTotal";
            // 
            // itemDiscount
            // 
            this.itemDiscount.HeaderText = "Discount";
            this.itemDiscount.Name = "itemDiscount";
            // 
            // cbItem
            // 
            this.cbItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbItem.FormattingEnabled = true;
            this.cbItem.Location = new System.Drawing.Point(20, 45);
            this.cbItem.Name = "cbItem";
            this.cbItem.Size = new System.Drawing.Size(300, 28);
            this.cbItem.TabIndex = 0;
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(39)))), ((int)(((byte)(176)))));
            this.lblItem.Location = new System.Drawing.Point(20, 15);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(41, 20);
            this.lblItem.TabIndex = 0;
            this.lblItem.Text = "Item";
            // 
            // txtItemQuantity
            // 
            this.txtItemQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemQuantity.Location = new System.Drawing.Point(20, 110);
            this.txtItemQuantity.Name = "txtItemQuantity";
            this.txtItemQuantity.Size = new System.Drawing.Size(300, 26);
            this.txtItemQuantity.TabIndex = 1;
            // 
            // txtQuantity
            // 
            this.txtQuantity.AutoSize = true;
            this.txtQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(39)))), ((int)(((byte)(176)))));
            this.txtQuantity.Location = new System.Drawing.Point(20, 80);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(68, 20);
            this.txtQuantity.TabIndex = 0;
            this.txtQuantity.Text = "Quantity";
            // 
            // txtDiscount
            // 
            this.txtDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiscount.Location = new System.Drawing.Point(20, 175);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(300, 26);
            this.txtDiscount.TabIndex = 2;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(39)))), ((int)(((byte)(176)))));
            this.lblDiscount.Location = new System.Drawing.Point(20, 145);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(72, 20);
            this.lblDiscount.TabIndex = 0;
            this.lblDiscount.Text = "Discount";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(20, 210);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 34);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add Item";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnGenerateBill
            // 
            this.btnGenerateBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnGenerateBill.FlatAppearance.BorderSize = 0;
            this.btnGenerateBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateBill.ForeColor = System.Drawing.Color.White;
            this.btnGenerateBill.Location = new System.Drawing.Point(132, 210);
            this.btnGenerateBill.Name = "btnGenerateBill";
            this.btnGenerateBill.Size = new System.Drawing.Size(127, 34);
            this.btnGenerateBill.TabIndex = 8;
            this.btnGenerateBill.Text = "Generate Bill";
            this.btnGenerateBill.UseVisualStyleBackColor = false;
            // 
            // SalesCtrl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.btnGenerateBill);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.txtItemQuantity);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.cbItem);
            this.Controls.Add(this.salesListPanel);
            this.Name = "SalesCtrl";
            this.Size = new System.Drawing.Size(1050, 580);
            this.Load += new System.EventHandler(this.SalesCtrl_Load);
            this.salesListPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgSalesItemList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel salesListPanel;
        private System.Windows.Forms.ComboBox cbItem;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.TextBox txtItemQuantity;
        private System.Windows.Forms.Label txtQuantity;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgSalesItemList;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDiscount;
        private System.Windows.Forms.Button btnGenerateBill;
    }
}
