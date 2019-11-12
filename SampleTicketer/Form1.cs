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
            //Connects to the server
            //NOTE:The user account running this program MUST be able to create a remote connection to the server (See: RDP capabilities)
            string connetionString;
            SqlConnection cnn;
<<<<<<< Updated upstream

            connetionString = @"Server=tulsa002\sqlexpress;Database=iticket;User ID=iticket;Password=password";
=======
            connetionString = @"Server=tcp:172.30.32.61\SQLEXPRESS,60491;Database=test;Trusted_Connection=True;";
            //connetionString = @"Server=tulsa002\sqlexpress;Database=iticket;Trusted_Connection=True;";
>>>>>>> Stashed changes
            using (cnn = new SqlConnection(connetionString))
            {
                try
                {
                    //Initialize variables
                    int ticketNum = 0;
                    string fName = txtFirstName.Text;
                    string lName = txtLastName.Text;
                    string email = txtEmail.Text;
                    string phoneNumber = txtPhoneNumber.Text;
                    var dateCreated = dtpDateCreated.Value.Date;
                    var dateDue = dtpDueDate.Value.Date;
                    string assignedPriority = null;
                    string origPerson = lbPersonAssigned.SelectedItem.ToString();
                    string personAssigned = origPerson;
                    string description = txtDescription.Text;
                    string status = null;
                    int timeSpentWorking = 0;

                    cnn.Open();

                    //Assign ticket number to submitted ticket
                    string ticketNumSQL = "select max(ticketNum) from dbo.Ticket";
                    using (SqlDataReader reader = new SqlCommand(ticketNumSQL, cnn).ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            ticketNum = reader.GetInt32(0) + 1;
                        }
                    }

                    //Remove non-numeric characters from phone number
                    foreach (char ch in phoneNumber)
                    {
                        if (!char.IsNumber(ch))
                        {
                            phoneNumber = phoneNumber.Replace(ch.ToString(), "");
                        }
                    }

                    //Data Validation
                    if (email == string.Empty || phoneNumber == string.Empty || origPerson == string.Empty || description == string.Empty)
                    {
                        throw new Exception();
                    }

                    //Set ticket information into the database
                    string sql = "Insert into ticket values(@param1,@param2,@param3,@param4,@param5,@param6,@param7,@param8,@param9,@param10,@param11,@param12,@param13)";
                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.Parameters.Add("@param1", System.Data.SqlDbType.Int).Value = ticketNum;
                        cmd.Parameters.Add("@param2", System.Data.SqlDbType.VarChar, 20).Value = fName;
                        cmd.Parameters.Add("@param3", System.Data.SqlDbType.VarChar, 20).Value = lName;
                        cmd.Parameters.Add("@param4", System.Data.SqlDbType.VarChar, 75).Value = email;
                        cmd.Parameters.Add("@param5", System.Data.SqlDbType.VarChar, 15).Value = phoneNumber;
                        cmd.Parameters.Add("@param6", System.Data.SqlDbType.Date).Value = dateCreated;
                        cmd.Parameters.Add("@param7", System.Data.SqlDbType.Date).Value = dateDue;
                        cmd.Parameters.Add("@param8", System.Data.SqlDbType.VarChar, 30).Value = DBNull.Value;
                        cmd.Parameters.Add("@param9", System.Data.SqlDbType.VarChar, 30).Value = origPerson;
                        cmd.Parameters.Add("@param10", System.Data.SqlDbType.VarChar, 30).Value = personAssigned;
                        cmd.Parameters.Add("@param11", System.Data.SqlDbType.VarChar, 1500).Value = description;
                        cmd.Parameters.Add("@param12", System.Data.SqlDbType.VarChar, 20).Value = DBNull.Value;
                        cmd.Parameters.Add("@param13", System.Data.SqlDbType.VarChar, 30).Value = timeSpentWorking;

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Finished! :)");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "SQL Connection Failed");
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Please Select a Technician", "Error");
                }
                catch (Exception)
                {
                    MessageBox.Show("Please fill out required information", "Incomplete");
                }
            }
        }
    }
}
