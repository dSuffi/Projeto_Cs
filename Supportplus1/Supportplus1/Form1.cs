using Supportplus1.DataSet1TableAdapters;
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
    public partial class Form1 : Form
    {
        private int tela;

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(int i)
        {
            InitializeComponent();
            tela = i;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            UsuarioTableAdapter login = new UsuarioTableAdapter();
            DataTable UsuarioLogin;
            UsuarioLogin = login.Login(TxtUsuario.Text,TxtSenha.Text);



            if (UsuarioLogin.Rows.Count > 0)
            {
                if (tela == 1)
                {
                    AdmForm adm = new AdmForm();
                    adm.Visible = true;
                    this.Visible = false;
                    
                }
                else
                {
                    secondform novo = new secondform();
                    novo.Show(this);
                    
                    this.Visible = false;
                }


            }

            if (UsuarioLogin.Rows.Count == 0)
            {

                MessageBox.Show("Usuario ou Senha incorretos");
            }
            
           
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Loader.closeApp();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
