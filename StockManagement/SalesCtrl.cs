using System.Data;
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
            string selectItem = "SELECT * FROM Item";
            DataTable itemData = DatabaseConnection.GetTable(selectItem, null, CommandType.Text);
            if (itemData.Rows.Count > 0)
            {
                cbItem.DataSource = itemData;
                cbItem.ValueMember = "ItemID";
                cbItem.DisplayMember = "ItemName";
            }
        }

        private void AddSalesItemToDataGrid()
        {
            int count = dgSalesItemList.Rows.Count;
            dgSalesItemList.Rows.Add();
            dgSalesItemList.Rows[count].Cells["itemID"].Value = cbItem.SelectedValue;
            dgSalesItemList.Rows[count].Cells["serialNo"].Value = count+1;
            dgSalesItemList.Rows[count].Cells["itemName"].Value = cbItem.Text;
            dgSalesItemList.Rows[count].Cells["itemPrice"].Value = "null";
            dgSalesItemList.Rows[count].Cells["itemQuantity"].Value = txtItemQuantity.Text;
            dgSalesItemList.Rows[count].Cells["itemTotal"].Value = "null";
            dgSalesItemList.Rows[count].Cells["itemDiscount"].Value = "null";
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            AddSalesItemToDataGrid();
        }
    }
}
