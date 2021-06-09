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
            userControl11.Hide();
            userControl21.Hide();
            userConAddBook1.Show();
            userConAddBook1.BringToFront();
            userConBookInquiries1.Hide();
            userConEditBook1.Hide();
            userConLendBooks1.Hide();
            userConReturnBook1.Hide();
            userConMemReg1.Hide();
            userConMemUnreg1.Hide();
            userConReserveBook1.Hide();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            userConAddBook1.Show();
            userConAddBook1.BringToFront();
            userConBookInquiries1.Hide();
            userConEditBook1.Hide();
            userConLendBooks1.Hide();
            userConReturnBook1.Hide();
            userConMemReg1.Hide();
            userConMemUnreg1.Hide();
            userConReserveBook1.Hide();
          
        }

        private void removebtn_Click(object sender, EventArgs e)
        {
            userConAddBook1.Hide();
            userConBookInquiries1.Hide();
            userConEditBook1.Hide();
            userConLendBooks1.Hide();
            userConReturnBook1.Hide();
            userConMemReg1.Hide();
            userConMemUnreg1.Show();
            userConMemUnreg1.BringToFront();
            userConReserveBook1.Hide();
            
        }

        private void editBookBtn_Click(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl21.Hide();
            userConAddBook1.Hide();
            userConBookInquiries1.Hide();
            userConEditBook1.Show();
            userConEditBook1.BringToFront();
            userConLendBooks1.Hide();
            userConReturnBook1.Hide();
            userConMemReg1.Hide();
            userConMemUnreg1.Hide();
            userConReserveBook1.Hide();
        }

        private void returnBookBtn_Click(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl21.Hide();
            userConAddBook1.Hide();
            userConBookInquiries1.Hide();
            userConEditBook1.Hide();
            userConLendBooks1.Hide();
            userConReturnBook1.Show();
            userConReturnBook1.BringToFront();
            userConMemReg1.Hide();
            userConMemUnreg1.Hide();
            userConReserveBook1.Hide();
        }

        private void lendBtn_Click(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl21.Hide();
            userConAddBook1.Hide();
            userConBookInquiries1.Hide();
            userConEditBook1.Hide();
            userConLendBooks1.Show();
            userConLendBooks1.BringToFront();
            userConReturnBook1.Hide();
            userConMemReg1.Hide();
            userConMemUnreg1.Hide();
            userConReserveBook1.Hide();
        }

        private void memRegBtn_Click(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl21.Hide();
            userConAddBook1.Hide();
            userConBookInquiries1.Hide();
            userConEditBook1.Hide();
            userConLendBooks1.Hide();
            userConReturnBook1.Hide();
            userConMemReg1.Show();
            userConMemReg1.BringToFront();
            userConMemUnreg1.Hide();
            userConReserveBook1.Hide();
        }

        private void booksInquiries_Click(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl21.Hide();
            userConAddBook1.Hide();
            userConBookInquiries1.Show();
            userConBookInquiries1.BringToFront();
            userConEditBook1.Hide();
            userConLendBooks1.Hide();
            userConReturnBook1.Hide();
            userConMemReg1.Hide();
            userConMemUnreg1.Hide();
            userConReserveBook1.Hide();
        }

        private void reserveBooksBtn_Click(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl21.Hide();
            userConAddBook1.Hide();
            userConBookInquiries1.Hide();
            userConEditBook1.Hide();
            userConLendBooks1.Hide();
            userConReturnBook1.Hide();
            userConMemReg1.Hide();
            userConMemUnreg1.Hide();
            userConReserveBook1.Show();
            userConReserveBook1.BringToFront();
        }

        private void memUnRegBtn_Click(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl21.Hide();
            userConAddBook1.Show();
            userConBookInquiries1.Hide();
            userConEditBook1.Hide();
            userConLendBooks1.Hide();
            userConReturnBook1.Hide();
            userConMemReg1.Hide();
            userConMemUnreg1.Show();
            userConMemUnreg1.BringToFront();
            userConReserveBook1.Hide();
        }
    }
}
