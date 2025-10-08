using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics; // Required for Process.Start (e.g., mailto)
using Guna.UI2.WinForms; // Include if Guna controls are used outside InitializeComponent

namespace RealEstateManagement
{
    public partial class frmOwnerDetails : Form
    {
        private frmMain _mainForm;
        private int _ownerId;
        private string _ownerEmail; // Stored to make it accessible to the message button
        private string _ownerPhone; // Stored to make it accessible to the phone button

        public frmOwnerDetails(frmMain mainForm, int ownerId)
        {
            InitializeComponent();
            _mainForm = mainForm;
            _ownerId = ownerId;
        }

    }
}