namespace SalesManagement
{
    partial class AddSubCategoryCtrl
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtSubCatName = new System.Windows.Forms.TextBox();
            this.lblSubCatName = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.txtCatDescription = new System.Windows.Forms.TextBox();
            this.lblSubCatDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(41)))), ((int)(((byte)(37)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(288, 360);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(127, 46);
            this.btnClear.TabIndex = 4;
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
            this.btnSave.Location = new System.Drawing.Point(114, 360);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(132, 46);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // txtSubCatName
            // 
            this.txtSubCatName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubCatName.Location = new System.Drawing.Point(45, 65);
            this.txtSubCatName.Name = "txtSubCatName";
            this.txtSubCatName.Size = new System.Drawing.Size(370, 30);
            this.txtSubCatName.TabIndex = 0;
            // 
            // lblSubCatName
            // 
            this.lblSubCatName.AutoSize = true;
            this.lblSubCatName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubCatName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(39)))), ((int)(((byte)(176)))));
            this.lblSubCatName.Location = new System.Drawing.Point(45, 30);
            this.lblSubCatName.Name = "lblSubCatName";
            this.lblSubCatName.Size = new System.Drawing.Size(230, 29);
            this.lblSubCatName.TabIndex = 0;
            this.lblSubCatName.Text = "Sub Category Name";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(39)))), ((int)(((byte)(176)))));
            this.lblCategory.Location = new System.Drawing.Point(45, 98);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(110, 29);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Category";
            // 
            // cbCategory
            // 
            this.cbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(45, 133);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(370, 33);
            this.cbCategory.TabIndex = 1;
            // 
            // txtCatDescription
            // 
            this.txtCatDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCatDescription.Location = new System.Drawing.Point(45, 201);
            this.txtCatDescription.Multiline = true;
            this.txtCatDescription.Name = "txtCatDescription";
            this.txtCatDescription.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtCatDescription.Size = new System.Drawing.Size(370, 100);
            this.txtCatDescription.TabIndex = 2;
            // 
            // lblSubCatDescription
            // 
            this.lblSubCatDescription.AutoSize = true;
            this.lblSubCatDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubCatDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(39)))), ((int)(((byte)(176)))));
            this.lblSubCatDescription.Location = new System.Drawing.Point(40, 169);
            this.lblSubCatDescription.Name = "lblSubCatDescription";
            this.lblSubCatDescription.Size = new System.Drawing.Size(135, 29);
            this.lblSubCatDescription.TabIndex = 0;
            this.lblSubCatDescription.Text = "Description";
            // 
            // AddSubCategoryCtrl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.txtCatDescription);
            this.Controls.Add(this.lblSubCatDescription);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.txtSubCatName);
            this.Controls.Add(this.lblSubCatName);
            this.Name = "AddSubCategoryCtrl";
            this.Size = new System.Drawing.Size(1050, 580);
            this.Load += new System.EventHandler(this.AddSubCategoryCtrl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtSubCatName;
        private System.Windows.Forms.Label lblSubCatName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.TextBox txtCatDescription;
        private System.Windows.Forms.Label lblSubCatDescription;
    }
}
