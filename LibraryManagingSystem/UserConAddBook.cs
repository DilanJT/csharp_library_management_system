using System;
using System.Windows.Forms;

namespace LibraryManagingSystem
{
    public partial class UserConAddBook : UserControl
    {
        public UserConAddBook()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            String bookNumber = txtBookNumber.Text;
            String bookTitle = txtBookTitle.Text;
            int numberOfCopies = 0;

            try
            {
                numberOfCopies = Convert.ToInt32(txtNumCopies);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please fill the number of copies which is less than 10");
            }
            String bookPublisher = txtBookPublisher.Text;
            String availability = "true";
            String reserve = "false";
            String referenceOnly = null;
            if (radioRefTrue.Checked)
            {
                referenceOnly = "true";
            }
            else if (refRadioFalse.Checked)
            {
                referenceOnly = "False";
            }

            if (numberOfCopies > 10)
            {
                MessageBox.Show("You can only register maximum of 10 books. Please enter the number of books again");
            }

            try
            {
                MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=password;database=librarysystem");
                String query = "INSERT INTO book " +
                               "(bookNumber, bookTitle, numCopies, referenceOnly, publisher, availability, reserve) VALUES " +
                               "('" + BookNumber + "','" + BookTitle + "'," + NumCopies + ",'" + ReferenceOnly + "','" + BookPublisher + "','" + availability + "','" + Reserve + "');";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                //MySqlDataReader reader;
                conn.Open();
                cmd.ExecuteReader();
                MessageBox.Show(BookNumber + " got successfully registered.");
                conn.Close();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
