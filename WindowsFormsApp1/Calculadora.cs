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
    public partial class Calculadora : Form
    {
        private int Numero1 = 0;
        private int Numero2 = 0;
        char operacao = ' ';

        public Calculadora()
        {
            InitializeComponent();

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            txtNumeros.Text = "";
            Numero1 = 0;
            Numero2 = 0;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (txtNumeros.Text != "0")
            {
                txtNumeros.Text = txtNumeros.Text + 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VerificaPrimeiroDigito();
            txtNumeros.Text = txtNumeros.Text + 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VerificaPrimeiroDigito();
            txtNumeros.Text = txtNumeros.Text + 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VerificaPrimeiroDigito();
            txtNumeros.Text = txtNumeros.Text + 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            VerificaPrimeiroDigito();
            txtNumeros.Text = txtNumeros.Text + 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            VerificaPrimeiroDigito();
            txtNumeros.Text = txtNumeros.Text + 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            VerificaPrimeiroDigito();
            txtNumeros.Text = txtNumeros.Text + 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            VerificaPrimeiroDigito();
            txtNumeros.Text = txtNumeros.Text + 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            VerificaPrimeiroDigito();
            txtNumeros.Text = txtNumeros.Text + 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            VerificaPrimeiroDigito();
            txtNumeros.Text = txtNumeros.Text + 9;
        }

        private void buttonSoma_Click(object sender, EventArgs e)
        {
            BotaoSomar();
        }

        private void BotaoSomar()
        {
            Numero1 = Convert.ToInt32(txtNumeros.Text);
            operacao = '+';
            txtNumeros.Text = "0";
        }

        private void buttonIgual_Click(object sender, EventArgs e)
        {
            Calcular();
        }

        private void Calcular()
        {
            if (Numero1 != 0)
            {
                if (!string.IsNullOrEmpty(txtNumeros.Text))
                {
                    Numero2 = Convert.ToInt32(txtNumeros.Text);
                    switch (operacao)
                    {
                        case '+':
                            txtNumeros.Text = Convert.ToString(Numero1 + Numero2);
                            break;
                        case '-':
                            txtNumeros.Text = Convert.ToString(Numero1 - Numero2);
                            break;
                        case '*':
                            txtNumeros.Text = Convert.ToString(Numero1 * Numero2);
                            break;
                        case '/':
                            txtNumeros.Text = Convert.ToString(Numero1 / Numero2);
                            break;
                    }
                }

            }
        }

        private void VerificaPrimeiroDigito()
        {
            if (txtNumeros.Text == "0")
            {
                txtNumeros.Text = "";
            }
        }

        private void buttonSubtracao_Click(object sender, EventArgs e)
        {
            BotaoSubtrair();
        }

        private void BotaoSubtrair()
        {
            Numero1 = Convert.ToInt32(txtNumeros.Text);
            operacao = '-';
            txtNumeros.Text = "0";
        }

        private void buttonMultiplicacao_Click(object sender, EventArgs e)
        {
            BotaoMultiplicar();
        }

        private void BotaoMultiplicar()
        {
            Numero1 = Convert.ToInt32(txtNumeros.Text);
            operacao = '*';
            txtNumeros.Text = "0";
        }

        private void buttonDivisao_Click(object sender, EventArgs e)
        {
            BotaoDividir();
        }

        private void BotaoDividir()
        {
            Numero1 = Convert.ToInt32(txtNumeros.Text);
            operacao = '/';
            txtNumeros.Text = "0";
        }

        private void Calculadora_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad9)
            {
                VerificaPrimeiroDigito();
                txtNumeros.Text = txtNumeros.Text + 9;
            }
            else if (e.KeyCode == Keys.NumPad8)
            {
                VerificaPrimeiroDigito();
                txtNumeros.Text = txtNumeros.Text + 8;
            }
            else if (e.KeyCode == Keys.NumPad7)
            {
                VerificaPrimeiroDigito();
                txtNumeros.Text = txtNumeros.Text + 7;
            }
            else if (e.KeyCode == Keys.NumPad6)
            {
                VerificaPrimeiroDigito();
                txtNumeros.Text = txtNumeros.Text + 6;
            }
            else if (e.KeyCode == Keys.NumPad5)
            {
                VerificaPrimeiroDigito();
                txtNumeros.Text = txtNumeros.Text + 5;
            }
            else if (e.KeyCode == Keys.NumPad4)
            {
                VerificaPrimeiroDigito();
                txtNumeros.Text = txtNumeros.Text + 4;
            }
            else if (e.KeyCode == Keys.NumPad3)
            {
                VerificaPrimeiroDigito();
                txtNumeros.Text = txtNumeros.Text + 3;
            }
            else if (e.KeyCode == Keys.NumPad2)
            {
                VerificaPrimeiroDigito();
                txtNumeros.Text = txtNumeros.Text + 2;
            }
            else if (e.KeyCode == Keys.NumPad1)
            {
                VerificaPrimeiroDigito();
                txtNumeros.Text = txtNumeros.Text + 1;
            }
            else if (e.KeyCode == Keys.NumPad0)
            {
                VerificaPrimeiroDigito();
                txtNumeros.Text = txtNumeros.Text + 0;
            }
            else if (e.KeyCode == Keys.Add)
            {
                BotaoSomar();
            }
            else if (e.KeyCode == Keys.Divide)
            {
                BotaoDividir();
            }
            else if (e.KeyCode == Keys.Multiply)
            {
                BotaoMultiplicar();
            }
            else if (e.KeyCode == Keys.Subtract)
            {
                BotaoSubtrair();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                Calcular();
            }
        }
    }
}
