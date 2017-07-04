namespace SalesManagement
{
    partial class AddPurchase
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
            this.txtCostPrice = new System.Windows.Forms.TextBox();
            this.lblCostPrice = new System.Windows.Forms.Label();
            this.cbItemName = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtpPuchasedOn = new System.Windows.Forms.DateTimePicker();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtPurchasedFrom = new System.Windows.Forms.TextBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblPurchaseFrom = new System.Windows.Forms.Label();
            this.lblPurchasedOn = new System.Windows.Forms.Label();
            this.lbltemColor = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.cbSize = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtCostPrice
            // 
            this.txtCostPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostPrice.Location = new System.Drawing.Point(66, 299);
            this.txtCostPrice.Name = "txtCostPrice";
            this.txtCostPrice.Size = new System.Drawing.Size(350, 30);
            this.txtCostPrice.TabIndex = 3;
            // 
            // lblCostPrice
            // 
            this.lblCostPrice.AutoSize = true;
            this.lblCostPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(39)))), ((int)(((byte)(176)))));
            this.lblCostPrice.Location = new System.Drawing.Point(66, 264);
            this.lblCostPrice.Name = "lblCostPrice";
            this.lblCostPrice.Size = new System.Drawing.Size(124, 29);
            this.lblCostPrice.TabIndex = 0;
            this.lblCostPrice.Text = "Cost Price";
            // 
            // cbItemName
            // 
            this.cbItemName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbItemName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbItemName.FormattingEnabled = true;
            this.cbItemName.Location = new System.Drawing.Point(65, 62);
            this.cbItemName.Name = "cbItemName";
            this.cbItemName.Size = new System.Drawing.Size(350, 33);
            this.cbItemName.TabIndex = 0;
            this.cbItemName.SelectedIndexChanged += new System.EventHandler(this.cbItemName_TextUpdate);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(41)))), ((int)(((byte)(37)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(700, 374);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 40);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(500, 374);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 40);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtpPuchasedOn
            // 
            this.dtpPuchasedOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPuchasedOn.Location = new System.Drawing.Point(500, 223);
            this.dtpPuchasedOn.Name = "dtpPuchasedOn";
            this.dtpPuchasedOn.Size = new System.Drawing.Size(350, 30);
            this.dtpPuchasedOn.TabIndex = 6;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(500, 62);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(350, 30);
            this.txtQuantity.TabIndex = 4;
            // 
            // txtPurchasedFrom
            // 
            this.txtPurchasedFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurchasedFrom.Location = new System.Drawing.Point(500, 139);
            this.txtPurchasedFrom.Name = "txtPurchasedFrom";
            this.txtPurchasedFrom.Size = new System.Drawing.Size(350, 30);
            this.txtPurchasedFrom.TabIndex = 5;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(39)))), ((int)(((byte)(176)))));
            this.lblSize.Location = new System.Drawing.Point(66, 184);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(60, 29);
            this.lblSize.TabIndex = 0;
            this.lblSize.Text = "Size";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(39)))), ((int)(((byte)(176)))));
            this.lblQuantity.Location = new System.Drawing.Point(500, 30);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(100, 29);
            this.lblQuantity.TabIndex = 0;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblPurchaseFrom
            // 
            this.lblPurchaseFrom.AutoSize = true;
            this.lblPurchaseFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchaseFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(39)))), ((int)(((byte)(176)))));
            this.lblPurchaseFrom.Location = new System.Drawing.Point(500, 104);
            this.lblPurchaseFrom.Name = "lblPurchaseFrom";
            this.lblPurchaseFrom.Size = new System.Drawing.Size(183, 29);
            this.lblPurchaseFrom.TabIndex = 0;
            this.lblPurchaseFrom.Text = "Puchased From";
            // 
            // lblPurchasedOn
            // 
            this.lblPurchasedOn.AutoSize = true;
            this.lblPurchasedOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchasedOn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(39)))), ((int)(((byte)(176)))));
            this.lblPurchasedOn.Location = new System.Drawing.Point(500, 184);
            this.lblPurchasedOn.Name = "lblPurchasedOn";
            this.lblPurchasedOn.Size = new System.Drawing.Size(166, 29);
            this.lblPurchasedOn.TabIndex = 0;
            this.lblPurchasedOn.Text = "Purchased On";
            // 
            // lbltemColor
            // 
            this.lbltemColor.AutoSize = true;
            this.lbltemColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltemColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(39)))), ((int)(((byte)(176)))));
            this.lbltemColor.Location = new System.Drawing.Point(66, 104);
            this.lbltemColor.Name = "lbltemColor";
            this.lbltemColor.Size = new System.Drawing.Size(72, 29);
            this.lbltemColor.TabIndex = 0;
            this.lbltemColor.Text = "Color";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(39)))), ((int)(((byte)(176)))));
            this.lblItemName.Location = new System.Drawing.Point(60, 30);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(130, 29);
            this.lblItemName.TabIndex = 0;
            this.lblItemName.Text = "Item Name";
            // 
            // cbColor
            // 
            this.cbColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Location = new System.Drawing.Point(66, 139);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(350, 33);
            this.cbColor.TabIndex = 1;
            this.cbColor.SelectedIndexChanged += new System.EventHandler(this.cbColor_SelectedIndexChanged);
            // 
            // cbSize
            // 
            this.cbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSize.FormattingEnabled = true;
            this.cbSize.Location = new System.Drawing.Point(66, 219);
            this.cbSize.Name = "cbSize";
            this.cbSize.Size = new System.Drawing.Size(350, 33);
            this.cbSize.TabIndex = 2;
            // 
            // AddPurchase
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.cbSize);
            this.Controls.Add(this.cbColor);
            this.Controls.Add(this.txtCostPrice);
            this.Controls.Add(this.lblCostPrice);
            this.Controls.Add(this.cbItemName);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpPuchasedOn);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtPurchasedFrom);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblPurchaseFrom);
            this.Controls.Add(this.lblPurchasedOn);
            this.Controls.Add(this.lbltemColor);
            this.Controls.Add(this.lblItemName);
            this.Name = "AddPurchase";
            this.Size = new System.Drawing.Size(1050, 580);
            this.Load += new System.EventHandler(this.AddPurchase_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCostPrice;
        private System.Windows.Forms.Label lblCostPrice;
        private System.Windows.Forms.ComboBox cbItemName;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dtpPuchasedOn;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtPurchasedFrom;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblPurchaseFrom;
        private System.Windows.Forms.Label lblPurchasedOn;
        private System.Windows.Forms.Label lbltemColor;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.ComboBox cbSize;
    }
}
