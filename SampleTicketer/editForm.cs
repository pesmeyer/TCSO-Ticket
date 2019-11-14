using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleTicketer
{
    public partial class editForm : Form
    {
        string updateID;
        public editForm(string id)
        {
            InitializeComponent();
            updateID = id;
        }
        private void editForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iTicketDataSet.Ticket' table. You can move, or remove it, as needed.
            this.ticketTableAdapter.FillBy(this.iTicketDataSet.Ticket, Int32.Parse(updateID));

        }

        private void btnUpdateEdit_Click(object sender, EventArgs e)
        {
            MainForm mform = new MainForm();

            
            this.Validate();
            this.ticketBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iTicketDataSet);
            this.Close();
        }
    }
}
