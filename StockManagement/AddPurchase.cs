using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SalesManagement
{
    public partial class AddPurchase : UserControl
    {
        private static AddPurchase _instance;
        public static AddPurchase Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AddPurchase();
                return _instance;
            }
        }
        public AddPurchase()
        {
            InitializeComponent();
        }

        private void AddPurchase_Load(object sender, EventArgs e)
        {
            string query = "SELECT DISTINCT Item.ItemName, ItemDetails.ItemID FROM Item JOIN ItemDetails ON ItemDetails.ItemID = Item.ItemID";
            DataTable dtItemName = DatabaseConnection.GetTable(query, null, CommandType.Text);
            DataRow dr = dtItemName.NewRow();
            dr["ItemName"] = "Select Item Name";
            dtItemName.Rows.InsertAt(dr, 0);

            if (dtItemName.Rows.Count > 0)
            {
                cbItemName.DataSource = dtItemName;
                cbItemName.ValueMember = "ItemID";
                cbItemName.DisplayMember = "ItemName";
            }
        }

        private void cbItemName_TextUpdate(object sender, EventArgs e)
        {
            if (cbItemName.SelectedIndex!=0)
            {
                int itemId = Convert.ToInt32(cbItemName.SelectedValue);
                string query = "SELECT ItemDetails.ItemDetailsID, ItemDetails.Color FROM ItemDetails WHERE ItemID = @itemID";
                SqlParameter[] param = new SqlParameter[]
                {
                        new SqlParameter("@itemID", itemId)
                };
                DataTable dtColor = DatabaseConnection.GetTable(query, param, CommandType.Text);
                if (dtColor.Rows.Count > 0)
                {
                    cbColor.DataSource = dtColor;
                    cbColor.ValueMember = "ItemDetailsID";
                    cbColor.DisplayMember = "Color";
                }
            }
        }

        private void cbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
           
                int itemId = Convert.ToInt32(cbItemName.SelectedValue);
                string color = cbColor.Text;
                string query = "SELECT ItemDetails.ItemDetailsID, ItemDetails.Size FROM ItemDetails WHERE ItemID = @itemID AND Color = @color";
                SqlParameter[] param = new SqlParameter[]
                {
                        new SqlParameter("@itemID", itemId),
                        new SqlParameter("@color", color)
                };
                DataTable dtSize = DatabaseConnection.GetTable(query, param, CommandType.Text);
                if (dtSize.Rows.Count > 0)
                {
                    cbSize.DataSource = dtSize;
                    cbSize.ValueMember = "ItemDetailsID";
                    cbSize.DisplayMember = "Size";
                }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int itemDetailsID = Convert.ToInt32(cbSize.SelectedValue);
            string puchasedFrom = txtPurchasedFrom.Text;
            int puchasedQuantity;
            bool puchasedQuantityOutput = int.TryParse(txtQuantity.Text,out puchasedQuantity);
            double cost;
            bool costOutput = double.TryParse(txtCostPrice.Text, out cost);
            DateTime purchasedOn = DateTime.Parse(dtpPuchasedOn.Text);
            string query = "insertPurchae";
            SqlParameter[] param = new SqlParameter[]
               {
                        new SqlParameter("@itemDetailsID", itemDetailsID),
                        new SqlParameter("@puchasedFrom", puchasedFrom),
                        new SqlParameter("@puchasedQuantity", puchasedQuantity),
                        new SqlParameter("@cost", cost),
                        new SqlParameter("@puchasedOn", purchasedOn)
               };
            int result = DatabaseConnection.InsertData(query, param, CommandType.StoredProcedure);
            if (result>0)
            {
                string updateQuentityQuery = "UpdateQuantity";
                SqlParameter[] updateParam = new SqlParameter[]
                {
                    new SqlParameter("@itemDetailsId", itemDetailsID),
                    new SqlParameter("@quantity", puchasedQuantity)
                };
                DatabaseConnection.InsertData(updateQuentityQuery, updateParam, CommandType.StoredProcedure);
                if (MessageBox.Show("Purchase has been added.", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    Dashboard dboard = new Dashboard();
                    if (!dboard.dashboardPanel.Controls.Contains(ViewStocks.Instance))
                    {
                        dboard.dashboardPanel.Controls.Add(ViewStocks.Instance);
                        ViewStocks.Instance.Dock = DockStyle.Fill;
                        ViewStocks.Instance.BringToFront();
                    }
                    else
                    {
                        ViewStocks.Instance.BringToFront();
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCostPrice.Clear();
            txtQuantity.Clear();
            txtPurchasedFrom.Clear();
        }
    }
}