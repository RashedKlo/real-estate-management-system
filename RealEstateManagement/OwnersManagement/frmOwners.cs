using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // Required for database access

namespace RealEstateManagement
{
    // Class name is correct: frmOwners
    public partial class frmOwners : Form
    {
        private readonly frmMain _mainForm;
        private int _currentPage = 1;
        private const int PAGE_SIZE = 10;
        private int _totalPages = 1;
        private int _totalRecords = 0;
        private string _filterName = "";
        private string _filterPhone = "";

        // Assuming you have a static class for DB connection string (adjust as needed)
        private const string CONNECTION_STRING = "YourConnectionStringHere";

        public frmOwners(frmMain mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }
    }
}