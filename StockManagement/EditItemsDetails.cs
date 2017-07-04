using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SalesManagement
{
    public partial class EditItemsDetails : Form
    {
        public EditItemsDetails()
        {
            InitializeComponent();
        }
        public void LoadData(string id, string name, string quantity, string color, string price, string size, string weight)
        {

            txtQuantity.Text = quantity;
            txtColor.Text = color;
            txtCostPrice.Text = price;
            txtWeight.Text = weight;
            txtSize.Text = size;
            txtID.Text = id;
        }

        private void EditItemsDetails_Load(object sender, EventArgs e)
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

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            int itemId =  int.Parse(cbItemName.SelectedValue.ToString());
            int quantity = int.Parse(txtQuantity.Text);
            string color = txtColor.Text;
            string size = txtSize.Text;
            string weight = txtWeight.Text;
            decimal price = decimal.Parse(txtCostPrice.Text);
            DateTime purchasedOn = DateTime.Parse(dtpPuchasedOn.Text);

            string query = "UPDATE ItemDetails SET ItemID = @ItemID, Quantity = @Quantity, Color = @Color, Size = @Size, Weight = @Weight, Price = @Price, PurchasedOn= @PurchasedOn WHERE ItemDetailsID = @id";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@id", id),
                new SqlParameter("@ItemID", itemId),
                new SqlParameter("@Quantity", quantity),
                new SqlParameter("@Color", color),
                new SqlParameter("@Size", size),
                new SqlParameter("@Weight", weight),
                new SqlParameter("@Price", price),
                new SqlParameter("@PurchasedOn", purchasedOn)
            };
            int result = DatabaseConnection.InsertData(query, param, CommandType.Text);
            if (result > 0)
            {
                if (MessageBox.Show("Purchase has been updated.", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }
    }
}
