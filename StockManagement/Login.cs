using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SalesManagement
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "" || txtPassword.Text == "")
            {
                errorProvider1.SetError(txtEmail, "Email Is Required.");
                errorProvider1.SetError(txtPassword, "Password Is Required.");
                txtEmail.Focus();
            }
            else
            {
                string sql = "select * from Users where email = @email and password = @password";
                SqlParameter[] param = new SqlParameter[]
                {
                    new SqlParameter("@email", txtEmail.Text),
                    new SqlParameter("@password", txtPassword.Text)
                };

                DataTable dt = DatabaseConnection.GetTable(sql, param, CommandType.Text);

                Dashboard newDashboard = new Dashboard();
                if (dt.Rows.Count > 0)
                {
                    newDashboard.Show();
                    this.Hide();
                }
                else
                {
                    lblErrorMessage.Text = "Invalid username or password!";
                }
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit the system?", "Point of sales", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(cbShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            } else
            {
                txtPassword.PasswordChar = '*';
            }
        }
    }
}
