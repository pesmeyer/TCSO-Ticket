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
        public editForm()
        {
            InitializeComponent();
        }

        private void ticketBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ticketBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iTicketDataSet);

        }

        private void editForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iTicketDataSet.Ticket' table. You can move, or remove it, as needed.
            this.ticketTableAdapter.Fill(this.iTicketDataSet.Ticket);

        }

        private void btnUpdateEdit_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
