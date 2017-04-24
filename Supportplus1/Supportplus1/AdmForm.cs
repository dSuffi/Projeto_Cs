using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supportplus1
{
    public partial class AdmForm : Form
    {
        public AdmForm()
        {
            InitializeComponent();
        }

        private void AdmForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Feedback' table. You can move, or remove it, as needed.
            this.feedbackTableAdapter.Fill(this.dataSet1.Feedback);
            // TODO: This line of code loads data into the 'dataSet1.Ticket' table. You can move, or remove it, as needed.
            this.ticketTableAdapter.Fill(this.dataSet1.Ticket);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
