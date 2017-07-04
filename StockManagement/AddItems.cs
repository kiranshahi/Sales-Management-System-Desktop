using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SalesManagement
{
    public partial class AddItems : UserControl
    {
        private static AddItems _instance;
        public static AddItems Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AddItems();
                return _instance;
            }
        }
        public AddItems()
        {
            InitializeComponent();
        }

        private void AddItems_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM ItemSubCategory";
            DataTable dt = DatabaseConnection.GetTable(query, null, CommandType.Text);
            if (dt.Rows.Count > 0)
            {
                cbItemSubCategory.DataSource = dt;
                cbItemSubCategory.ValueMember = "ItemSubCategoryID";
                cbItemSubCategory.DisplayMember = "SubCategoryName";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string itemName = txtItemName.Text;
            string itemDescription = txtItemDescription.Text;
            int itemSubCategoryID = int.Parse(cbItemSubCategory.SelectedValue.ToString());
         
            string query = "INSERT INTO Item (ItemName, ItemDescription, ItemSubCategoryID) " +
                "VALUES (@ItemName, @ItemDescription, @ItemSubCategoryID)";
            SqlParameter[] param = new SqlParameter[]
            {
                        new SqlParameter("@ItemName", itemName),
                        new SqlParameter("@ItemDescription", itemDescription),
                        new SqlParameter("@ItemSubCategoryID", itemSubCategoryID)
            };
            int result = DatabaseConnection.InsertData(query, param, CommandType.Text);
            if (result > 0)
            {
                MessageBox.Show("Item has been saved.", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtItemName.Clear();
                txtItemDescription.Clear();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtItemDescription.Clear();
            txtItemName.Clear();
        }
    }
}
