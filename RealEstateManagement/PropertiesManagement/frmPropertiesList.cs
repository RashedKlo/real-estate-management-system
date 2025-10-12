using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Guna.UI2.WinForms; 

namespace RealEstateManagement
{
    public partial class frmPropertiesList : Form
    {
        // Reference to the main form to update the status bar
        public frmMain _mainForm;

        public frmPropertiesList(frmMain mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            _mainForm.UpdateStatusBar("Property List loaded.");
        }

    }
}