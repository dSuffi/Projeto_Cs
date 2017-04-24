using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Supportplus1.DataSet1TableAdapters;

namespace Supportplus1
{
    public partial class TicketForm : Form
    {
        public TicketForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            TicketTableAdapter ticket = new TicketTableAdapter();
            ticket.Insert(1, 1, "Problema Técnico", TxtTicket.Text, "Aberto", CmbUrgencia.SelectedItem.ToString(), DateTime.Now, DateTime.Now);
            this.Visible = false;
        }

        private void TicketForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Loader.closeApp();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TicketForm_Load(object sender, EventArgs e)
        {
            CmbUrgencia.SelectedIndex = 0;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
