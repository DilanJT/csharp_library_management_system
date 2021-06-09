using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LibraryManagingSystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }


        private void Dashboard_Load(object sender, EventArgs e)
        {
            userControl11.Show();
            userControl21.Hide();
            userConAddBook1.Hide();
            userConBookInquiries1.Hide();
            userConEditBook1.Hide();
            userConLendBooks1.Hide();
            userConMemReg1.Hide();
            userConMemUnreg1.Hide();
            userConReserveBook1.Hide();
            btnPanel1.Hide();
            btnPanel2.Hide();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
