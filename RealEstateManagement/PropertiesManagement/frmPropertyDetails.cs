using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;


namespace RealEstateManagement
{
    public partial class frmPropertyDetails : Form
    {
        private int _propertyID;
        private frmMain _mainForm;
       
        public frmPropertyDetails(frmMain mainForm, int propertyID)
        {
            InitializeComponent();
            _mainForm = mainForm;
            _propertyID = propertyID;
            _mainForm.UpdateStatusBar($"Viewing property details for ID: {propertyID}.");
        }
 }
}