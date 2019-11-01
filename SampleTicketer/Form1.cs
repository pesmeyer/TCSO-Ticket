using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SampleTicketer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            string connetionString;
            SqlConnection cnn;
            //connetionString = @"Server=SO-DM-00615\SQLEXPRESS,60491;Database=test;Trusted_Connection=True;";
            connetionString = @"Server=tulsa002\sqlexpress;Database=iticket;User ID=iticket;Password=password";
            using (cnn = new SqlConnection(connetionString))
            {
                try
                {
                    cnn.Open();
                    MessageBox.Show("Connection Open!");
                    cnn.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            //var con = ConfigurationManager.ConnectionStrings["SampleTicketer.Properties.Settings.ITicketConnectionString"].ToString();
            //using (SqlConnection cnn = new SqlConnection(con))
            //{
            //    cnn.Open();
            //    MessageBox.Show("Connection Successful!");
            //}

            //Form2 f2 = new Form2();
            //f2.ShowDialog();
        }
    }
}
