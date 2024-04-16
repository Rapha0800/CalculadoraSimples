using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraSimples
{
    public partial class ButtonCalculadora : Form
    {
        public ButtonCalculadora()
        {
            InitializeComponent();
        }

        enum operacoes
        {
            //*enum é uma lista de coisas*
            soma,
            subtrai,
            multiplica,
            divida,
            nenhuma
        }

        static operacoes ultimaoperacao = operacoes.nenhuma;
        private bool qtdVirgula;
        private static int qtdVirgila;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Clear();
            ultimaoperacao = operacoes.nenhuma;
        }
        

        private void buttonMenos_Click(object sender, EventArgs e)
        {
            if (ultimaoperacao == operacoes.nenhuma)
            {
                ultimaoperacao = operacoes.subtrai;
            }
            else
            {
                FazerCalculo(ultimaoperacao);
            }
            textBoxDisplay.Text += (sender as Button).Text;
        }

        private void buttonMais_Click(object sender, EventArgs e)
        {
            if (ultimaoperacao == operacoes.nenhuma)
            {
                ultimaoperacao = operacoes.soma;
            }
            else
            {
                FazerCalculo(ultimaoperacao);
            }
            textBoxDisplay.Text += (sender as Button).Text;
        }

        private void FazerCalculo(operacoes ultimaoperacao)
        {
            List<double> listaDeNumeros = new List<double>();

            //switch-case é uma estrutura de decião
            //String é texto.
            switch (ultimaoperacao)
            {
                case operacoes.soma:
                    listaDeNumeros = textBoxDisplay.Text.Split('+').Select(double.Parse).ToList();
                    textBoxDisplay.Text = (listaDeNumeros[0] + listaDeNumeros[1]).ToString();
                    break;
                case operacoes.subtrai:
                    listaDeNumeros = textBoxDisplay.Text.Split('-').Select(double.Parse).ToList();
                    textBoxDisplay.Text = (listaDeNumeros[0] - listaDeNumeros[1]).ToString();
                    break;
                case operacoes.multiplica:
                    listaDeNumeros = textBoxDisplay.Text.Split('*').Select(double.Parse).ToList();
                    textBoxDisplay.Text = (listaDeNumeros[0] * listaDeNumeros[1]).ToString();
                    break;
                case operacoes.divida:
                    try
                    {
                        listaDeNumeros = textBoxDisplay.Text.Split('/').Select(double.Parse).ToList();
                        textBoxDisplay.Text = (listaDeNumeros[0] / listaDeNumeros[1]).ToString();
                    }
                    catch (DivideByZeroException)
                    {
                        textBoxDisplay.Text = "Divisão por zero";
                    }
                    break;
                case operacoes.nenhuma:
                    break;
                default:
                    break;
            }
        }

        private void buttonDivisao_Click(object sender, EventArgs e)
        {
            if (ultimaoperacao == operacoes.nenhuma)
            {
                ultimaoperacao = operacoes.divida;
            }
            else
            {
                FazerCalculo(ultimaoperacao);
            }
            textBoxDisplay.Text += (sender as Button).Text;
        }

        private void buttonMultiplicacao_Click(object sender, EventArgs e)
        {
            if (ultimaoperacao == operacoes.nenhuma)
            {
                ultimaoperacao = operacoes.multiplica;
            }
            else
            {
                FazerCalculo(ultimaoperacao);
            }
            textBoxDisplay.Text += (sender as Button).Text;
        }

        private void buttonVirgula_Click(object sender, EventArgs e)
        {
            if (qtdVirgula)
            {
                return;
            }
            else
            {
                textBoxDisplay.Text += ",";
                NewMethod();
            }
        }

        private static void NewMethod()
        {
            qtdVirgila = 1;
        }

        private void buttonNum_click(object sender, EventArgs e)
        {
            //textBoxDisplay.Text += "0";
            textBoxDisplay.Text += (sender as Button).Text;
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxDisplay.Text);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = textBoxDisplay.Text.Remove(textBoxDisplay.Text.Length -1, 1);
        }

        private void buttonIgual_Click(object sender, EventArgs e)
        {
            // ! = diferente.
            if (ultimaoperacao != operacoes.nenhuma)
            {
                FazerCalculo(ultimaoperacao);
            }
            ultimaoperacao = operacoes.nenhuma;
        }

        private void buttonParenteses_Click(object sender, EventArgs e)
        {

        }
    }
    }


