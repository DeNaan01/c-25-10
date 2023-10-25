using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace monique_e_rery
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXBaltura_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BTNcalculo_Click(object sender, EventArgs e)
        {
            //calcular imc 


            int idade = int.Parse(TXBidade.Text);
            float altura = float.Parse(TXBaltura.Text);
            int peso = int.Parse(TXBpeso.Text);

            float alt2 = altura * altura;
            float imc = peso / alt2;
            LBresultado.Text = imc.ToString();
        }

        private void BTNdirigir_Click(object sender, EventArgs e)
        {
            int idade = int.Parse(TXBidade.Text);
            //float altura = float.Parse(TXBaltura.Text);
            //int peso = int.Parse(TXBpeso.Text);

            if (idade >= 18) 
            {
                LBresultado.Text = "Pode dirigir";

            }
            else
            {
                LBresultado.Text = "não pode dirigir";
            }


        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void BTNsimular_Click(object sender, EventArgs e)
        {
            float divida = float.Parse(TXBdivida.Text);
            int qtd = int.Parse(TXBqtd.Text);
            //float juros = float.Parse(TXBjuros.Text);

            if (divida >= 50000)
            {

                LBjuros.Text = "O valor do juros é" + divida + (divida * 0, 25).ToString();

            }
            else
            {
                LBjuros.Text = "O valor do juros é" + divida + (divida * 0, 5).ToString();

            }
        }
    }
}