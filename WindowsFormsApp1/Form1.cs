using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string sobrenome = txtSobrenome.Text;
            string nomeCompleto = String.Format("{0} {1}", nome, sobrenome);
            MessageBox.Show(nomeCompleto);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Calculadora().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new CadastroPessoa().Show();
        }
    }
}
