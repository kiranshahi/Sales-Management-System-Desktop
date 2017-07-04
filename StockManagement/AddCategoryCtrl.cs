using System.Windows.Forms;

namespace SalesManagement
{
    public partial class AddCategoryCtrl : UserControl
    {
        private static AddCategoryCtrl _instance;
        public static AddCategoryCtrl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AddCategoryCtrl();
                return _instance;
            }
        }
        public AddCategoryCtrl()
        {
            InitializeComponent();
        }
    }
}
