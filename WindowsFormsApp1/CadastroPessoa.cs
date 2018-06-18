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
    public partial class CadastroPessoa : Form
    {
        public CadastroPessoa()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtIdade.Text = "";
            txtPeso.Text = "";
            txtAltura.Text = "";
            cbEuAceitoOsTermos.Checked = false;
            cbEuLiOsTermos.Checked = false;
            rbSexoFeminino.Checked = false;
            rbSexoMasculino.Checked = false;
            rbStatusAprovado.Checked = false;
            rbStatusReprovado.Checked = false;
            rtbDescricao.Text = "";
            rtbResultado.Text = "";
            cbNacionalidade.SelectedIndex = -1;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            int idade = 0;
            try
            {
                idade = Convert.ToInt32(txtIdade.Text);

            }
            catch (Exception e1)
            {
                MessageBox.Show("Idade deve conter somente números");
                txtIdade.Focus();
                return;
            }

            double altura = 0;
            try
            {

                altura = Convert.ToDouble(txtAltura.Text);
            }
            catch (Exception e1)
            {
                MessageBox.Show("Altura deve conter somente números reais");
                txtAltura.Focus();
                return;
            }


            double peso = 0;
            try
            {

                peso = Convert.ToDouble(txtPeso.Text);
            }
            catch (Exception e1)
            {
                MessageBox.Show("Peso deve conter somente números reais");
                txtPeso.Focus();
                return;

            }

          
            double imc = peso / (altura * altura);
            if(cbNacionalidade.SelectedItem == null)
            {
                MessageBox.Show("Selecione uma nacionaldiade");
                cbNacionalidade.DroppedDown = true;
                return;
            }

            string nacionaldiade = cbNacionalidade.SelectedItem.ToString();
            string descricao = rtbDescricao.Text;
            bool euLiOsTermos = cbEuLiOsTermos.Checked;
            bool euAceitoOsTermos = cbEuAceitoOsTermos.Checked;

            if(!rbSexoFeminino.Checked && !rbSexoMasculino.Checked)
            {
                MessageBox.Show("Selecione o sexo");
                return;
            }

            char sexo = ' ';
            if (rbSexoFeminino.Checked)
            {
                sexo = 'F';
            }
            else if (rbSexoMasculino.Checked)
            {
                sexo = 'M';
            }


            if (!rbStatusAprovado.Checked && !rbStatusReprovado.Checked)
            {
                MessageBox.Show("Selecione o sexo");
                return;
            }

            bool aprovado = rbStatusAprovado.Checked ? true : false;
            if (!euLiOsTermos)
            {
                MessageBox.Show("Leia os termos");
                return;
            }

            if (!euAceitoOsTermos)
            {
                MessageBox.Show("Aceite os termos");
                return;
            }

            rtbResultado.Text = "IMC: " + imc;




        }
    }
}
