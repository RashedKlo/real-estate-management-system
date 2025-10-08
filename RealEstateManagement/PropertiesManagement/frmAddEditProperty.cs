
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace RealEstateManagement
{
    public partial class frmAddEditProperty : Form
    {
        private int _propertyID = -1;
        private frmMain _mainForm;

        private List<string> _uploadedImagePaths = new List<string>();

        public frmAddEditProperty(frmMain mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            lblTitle.Text = "إضافة عقار جديد";
            btnSave.Text = "حفظ العقار";
            _mainForm.UpdateStatusBar("جاهز لإضافة عقار جديد.");
        }



   
    
    }
}
