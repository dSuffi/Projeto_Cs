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
    public partial class Loader : Form
    {
        public static Form instance;
        public Loader()
        {
            InitializeComponent();
            Loader.instance = this;
        }

        private void Loader_Shown(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        public static void closeApp() {
            if (instance != null)
                Loader.instance.Close();
        }
    }
}
