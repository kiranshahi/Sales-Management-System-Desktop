using System;
using System.Data;
using System.Windows.Forms;

namespace SalesManagement
{
    public partial class AddSubCategoryCtrl : UserControl
    {
        private static AddSubCategoryCtrl _instance;
        public static AddSubCategoryCtrl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AddSubCategoryCtrl();
                return _instance;
            }
        }
        public AddSubCategoryCtrl()
        {
            InitializeComponent();
        }

        private void AddSubCategoryCtrl_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM ItemCategory";
            DataTable dt = DatabaseConnection.GetTable(query, null, CommandType.Text);
            if (dt.Rows.Count > 0)
            {
                cbCategory.DataSource = dt;
                cbCategory.ValueMember = "ItemCategoryID";
                cbCategory.DisplayMember = "Name";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSubCatName.Clear();
            txtCatDescription.Clear();
        }
    }
}
