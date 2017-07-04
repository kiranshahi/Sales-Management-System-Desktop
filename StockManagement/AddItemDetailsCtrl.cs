using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SalesManagement
{
    public partial class AddItemDetailsCtrl : UserControl
    {

        private static AddItemDetailsCtrl _instance;
        public static AddItemDetailsCtrl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AddItemDetailsCtrl();
                    return _instance;
            }
        }
        public AddItemDetailsCtrl()
        {
            InitializeComponent();
        }
        private void AddProductCtrl_Load(object sender, EventArgs e)
        {
            string selectItem = "SELECT * FROM Item";
            DataTable itemData = DatabaseConnection.GetTable(selectItem, null, CommandType.Text);
            if (itemData.Rows.Count > 0)
            {
                cbItemName.DataSource = itemData;
                cbItemName.ValueMember = "ItemID";
                cbItemName.DisplayMember = "ItemName";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCostPrice.Clear();
            txtColor.Clear();
            txtSize.Clear();
            txtWeight.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int itemId = int.Parse(cbItemName.SelectedValue.ToString());
            string color = txtColor.Text;
            string size = txtSize.Text;
            string weight = txtWeight.Text;
            decimal price = decimal.Parse(txtCostPrice.Text);

            string query = "INSERT INTO ItemDetails (ItemID, Color, Size, Weight, Price) " +
                "VALUES (@ItemID, @Color, @Size, @Weight, @Price)";
                    SqlParameter[] param = new SqlParameter[]
                    {
                        new SqlParameter("@ItemID", itemId),
                        new SqlParameter("@Color", color),
                        new SqlParameter("@Size", size),
                        new SqlParameter("@Weight", weight),
                        new SqlParameter("@Price", price)
                    };
            int result = DatabaseConnection.InsertData(query, param, CommandType.Text);
            if (result>0)
            {
                MessageBox.Show("Product has been saved.","Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}