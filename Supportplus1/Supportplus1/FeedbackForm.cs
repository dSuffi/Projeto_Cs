using Supportplus1.DataSet1TableAdapters;
using System;
using System.Windows.Forms;

namespace Supportplus1
{
    public partial class FeedbackForm : Form
    {
        public FeedbackForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void FeedbackForm_Load(object sender, EventArgs e)
        {

        }

        private void FeedbackForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Loader.closeApp();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FeedbackTableAdapter feedback = new FeedbackTableAdapter();
            feedback.Insert(1, true, "Avaliação de atendimento", TxtFeedback.Text, DateTimeOffset.Now, 1);
            this.Visible = false;
        }
    }
}
