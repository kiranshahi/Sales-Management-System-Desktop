using System.Windows.Forms;

namespace SalesManagement
{
    public partial class DashboardCtrl : UserControl
    {
        private static DashboardCtrl _instance;
        public static DashboardCtrl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DashboardCtrl();
                return _instance;
            }
        }

        public DashboardCtrl()
        {
            InitializeComponent();
        }
    }
}
