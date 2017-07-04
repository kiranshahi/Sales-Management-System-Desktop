using System;
using System.Windows.Forms;

namespace SalesManagement
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            dashboardPanel.Controls.Add(DashboardCtrl.Instance);
            DashboardCtrl.Instance.Dock = DockStyle.Fill;
            DashboardCtrl.Instance.BringToFront();
        }
        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (!dashboardPanel.Controls.Contains(AddItemDetailsCtrl.Instance))
            {
                dashboardPanel.Controls.Add(AddItemDetailsCtrl.Instance);
                AddItemDetailsCtrl.Instance.Dock = DockStyle.Fill;
                AddItemDetailsCtrl.Instance.BringToFront();
            } else
            {
                AddItemDetailsCtrl.Instance.BringToFront();
            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if (!dashboardPanel.Controls.Contains(AddCategoryCtrl.Instance))
            {
                dashboardPanel.Controls.Add(AddCategoryCtrl.Instance);
                AddCategoryCtrl.Instance.Dock = DockStyle.Fill;
                AddCategoryCtrl.Instance.BringToFront();
            }
            else
            {
                AddCategoryCtrl.Instance.BringToFront();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            DashboardCtrl.Instance.BringToFront();
        }

        private void btnSubCat_Click(object sender, EventArgs e)
        {
            if (!dashboardPanel.Controls.Contains(AddSubCategoryCtrl.Instance))
            {
                dashboardPanel.Controls.Add(AddSubCategoryCtrl.Instance);
                AddSubCategoryCtrl.Instance.Dock = DockStyle.Fill;
                AddSubCategoryCtrl.Instance.BringToFront();
            }
            else
            {
                AddSubCategoryCtrl.Instance.BringToFront();
            }
        }

        private void btnRecordSales_Click(object sender, EventArgs e)
        {
            if (!dashboardPanel.Controls.Contains(ViewStocks.Instance))
            {
                dashboardPanel.Controls.Add(ViewStocks.Instance);
                ViewStocks.Instance.Dock = DockStyle.Fill;
                ViewStocks.Instance.BringToFront();
            }
            else
            {
                ViewStocks.Instance.BringToFront();
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (!dashboardPanel.Controls.Contains(AddItems.Instance))
            {
                dashboardPanel.Controls.Add(AddItems.Instance);
                AddItems.Instance.Dock = DockStyle.Fill;
                AddItems.Instance.BringToFront();
            }
            else
            {
                AddItems.Instance.BringToFront();
            }
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            if (!dashboardPanel.Controls.Contains(SalesCtrl.Instance))
            {
                dashboardPanel.Controls.Add(SalesCtrl.Instance);
                SalesCtrl.Instance.Dock = DockStyle.Fill;
                SalesCtrl.Instance.BringToFront();
            }
            else
            {
                SalesCtrl.Instance.BringToFront();
            }
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            if (!dashboardPanel.Controls.Contains(AddPurchase.Instance))
            {
                dashboardPanel.Controls.Add(AddPurchase.Instance);
                AddPurchase.Instance.Dock = DockStyle.Fill;
                AddPurchase.Instance.BringToFront();
            }
            else
            {
                AddPurchase.Instance.BringToFront();
            }
        }
    }
}