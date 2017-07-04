using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SalesManagement
{
    public partial class ViewStocks : UserControl
    {
        private static ViewStocks _instance;
        public static ViewStocks Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ViewStocks();
                return _instance;
            }
        }
        public ViewStocks()
        {
            InitializeComponent();
        }

        private void ViewStocks_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void LoadGrid()
        {
            string sql = "select ItemDetailsID AS 'SN', ItemName AS 'Item Name', Quantity, Price, Color, Size, Weight from Item, ItemDetails where ItemDetails.ItemID = Item.ItemID";
            DataTable dt = DatabaseConnection.GetTable(sql, null, CommandType.Text);
            dgStock.Rows.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dgStock.Rows.Add();
                dgStock.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
                dgStock.Rows[i].Cells[1].Value = dt.Rows[i][1].ToString();
                dgStock.Rows[i].Cells[2].Value = dt.Rows[i][2].ToString();
                dgStock.Rows[i].Cells[3].Value = dt.Rows[i][3].ToString();
                dgStock.Rows[i].Cells[4].Value = dt.Rows[i][4].ToString();
                dgStock.Rows[i].Cells[5].Value = dt.Rows[i][5].ToString();
                dgStock.Rows[i].Cells[6].Value = dt.Rows[i][6].ToString();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int row = dgStock.CurrentCell.RowIndex;
                string id = Convert.ToString(dgStock.Rows[row].Cells[0].Value);
                string name = Convert.ToString(dgStock.Rows[row].Cells[1].Value);
                string quantity = Convert.ToString(dgStock.Rows[row].Cells[2].Value);
                string price = Convert.ToString(dgStock.Rows[row].Cells[3].Value);
                string color = Convert.ToString(dgStock.Rows[row].Cells[4].Value);
                string size = Convert.ToString(dgStock.Rows[row].Cells[5].Value);
                string weight = Convert.ToString(dgStock.Rows[row].Cells[6].Value);
                EditItemsDetails editItems = new EditItemsDetails();
                editItems.LoadData(id, name, quantity, color, price, size, weight);
                editItems.ShowDialog();
                LoadGrid();
            }
            catch (Exception ex)
            {
                throw ex;
                //MessageBox.Show("Some things went wrong.", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int row = dgStock.CurrentCell.RowIndex;
                int id = int.Parse((dgStock.Rows[row].Cells[0].Value).ToString());
                if (MessageBox.Show("Do you really what to delete this row!", "Error !", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    string selectItem = "DELETE FROM ItemDetails WHERE ItemDetailsID = @id";
                    SqlParameter[] param = new SqlParameter[]
                    {
                        new SqlParameter("@id", id)
                    };
                    int result = DatabaseConnection.InsertData(selectItem, param, CommandType.Text);
                    if (result > 0)
                    {
                        MessageBox.Show("Item has been deleted.", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadGrid();
                    }
                }
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message, "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
