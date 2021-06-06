using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LibraryManagingSystem
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            

            Dashboard dashboard = new Dashboard();
            dashboard.Show();

            //((Form)this.TopLevelControl).Close();
        }
    }
}
