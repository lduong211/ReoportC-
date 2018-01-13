using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookManagementBUS;
using BookManagementDAL;
namespace BookManagement.Forms
{
    public partial class frmBookManagement : Form
    {
        BooksBUS bookBUS = new BooksBUS();

        public frmBookManagement()
        {
            InitializeComponent();
            LoadDataInIt();
        }

        private void LoadDataInIt()
        {
           
        }


    }
}
