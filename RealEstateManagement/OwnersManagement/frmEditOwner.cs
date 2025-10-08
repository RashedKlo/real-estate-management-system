using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient; // Assuming you'll add real DB calls here

namespace RealEstateManagement
{
    public partial class frmEditOwner : Form
    {
        private frmMain _mainForm;
        private int _ownerId;
        public frmEditOwner(frmMain mainForm, int ownerId)
        {
            InitializeComponent();
            _mainForm = mainForm;
            _ownerId = ownerId;
     
        }

     
    }
}