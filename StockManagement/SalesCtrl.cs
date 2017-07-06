using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SalesManagement
{
    public partial class SalesCtrl : UserControl
    {
        private static SalesCtrl _instance;
        public static SalesCtrl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SalesCtrl();
                return _instance;
            }
        }
        public SalesCtrl()
        {
            InitializeComponent();
        }

        private void SalesCtrl_Load(object sender, System.EventArgs e)
        {
            string selectItem = "SELECT DISTINCT Item.ItemName, ItemDetails.ItemID FROM Item JOIN ItemDetails ON ItemDetails.ItemID = Item.ItemID";
            DataTable itemData = DatabaseConnection.GetTable(selectItem, null, CommandType.Text);
            DataRow dr = itemData.NewRow();
            dr["ItemName"] = "Select Item Name";
            itemData.Rows.InsertAt(dr, 0);
            if (itemData.Rows.Count > 0)
            {
                cbItem.DataSource = itemData;
                cbItem.ValueMember = "ItemID";
                cbItem.DisplayMember = "ItemName";
            }
        }

        private void AddSalesItemToDataGrid()
        {
            int itemDetailsId = int.Parse(cbSize.SelectedValue.ToString());
            string selectItem = "SELECT Price FROM ItemDetails WHERE ItemDetailsID = @itemDetailsId";
            SqlParameter[] param = new SqlParameter[]
               {
                        new SqlParameter("@itemDetailsId", itemDetailsId)
               };
            DataTable itemData = DatabaseConnection.GetTable(selectItem, param, CommandType.Text);
            int count = dgSalesItemList.Rows.Count;
            dgSalesItemList.Rows.Add();
            dgSalesItemList.Rows[count].Cells["itemID"].Value = cbItem.SelectedValue;
            dgSalesItemList.Rows[count].Cells["serialNo"].Value = count+1;
            dgSalesItemList.Rows[count].Cells["itemName"].Value = cbItem.Text;
            dgSalesItemList.Rows[count].Cells["itemColor"].Value = cbColor.Text;
            dgSalesItemList.Rows[count].Cells["itemSize"].Value = cbSize.Text;
            for (int i = 0; i < itemData.Rows.Count; i++)
            {
                dgSalesItemList.Rows[count].Cells["itemPrice"].Value = itemData.Rows[i]["Price"].ToString();
            }
            dgSalesItemList.Rows[count].Cells["itemQuantity"].Value = txtItemQuantity.Text;
            dgSalesItemList.Rows[count].Cells["itemTotal"].Value = "null";
            dgSalesItemList.Rows[count].Cells["itemDiscount"].Value = txtDiscount.Text;
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            AddSalesItemToDataGrid();
        }

        private void cbItem_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (cbItem.SelectedIndex != 0)
            {
                int itemId = Convert.ToInt32(cbItem.SelectedValue);
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
            int itemId = Convert.ToInt32(cbItem.SelectedValue);
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
    }
}
