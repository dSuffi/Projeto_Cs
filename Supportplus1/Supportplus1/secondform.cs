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
    public partial class secondform : Form
    {
        public secondform()
        {
            InitializeComponent();
        }

        private void secondform_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            RadioButton option = optionsGB.Controls.OfType<RadioButton>().FirstOrDefault(o => o.Checked);

            switch (option.Tag)
            {
                case "TICKET":
                    TicketForm ticketForm = new TicketForm();
                    ticketForm.Show();
                    break;
                case "RAMAL":
                    Ramal ramal = new Ramal();
                    ramal.Show();
                    break;
                case "FEEDBACK":
                    FeedbackForm feedback = new FeedbackForm();
                    feedback.Show();
                    break;
                default:
                    break;

            }
        }

        private void CANCELAR_Click(object sender, EventArgs e)
        {
            CANCELAR.DialogResult = DialogResult.Cancel;
            this.Visible = false;
        }

        private void secondform_FormClosed(object sender, FormClosedEventArgs e)
        {
            Loader.closeApp();
        }

        private void optionsGB_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            /*AdmForm novo = new AdmForm();
            novo.Show();
            */

            Form1 frm = new Form1(1);
            frm.Visible = true;
        }
    }

}
