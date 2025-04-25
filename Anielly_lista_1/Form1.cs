using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anielly_lista_1
{
    public partial class Form1 : Form
    {
        double ra, pi, resul;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //const double PI = 3.1415;

            //Faça um algoritmo para calcular a área de uma circunferência, considerando a fórmula ÁREA = π * RAIO2. 
            //Utilize as variáveis AREA e RAIO, a constante π(pi = 3, 14159) e os operadores aritméticos de multiplicação.
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ra = double.Parse(textBox1.Text);
                pi = Math.PI;
                resul = Math.Round ( pi * (ra * ra), 2); //pi dentro de um parenteses, e dentro desse do pi tem outro com o raio dentro, virgula + 2 para quantos digitos quero depois da casa decimal
                label5.Text = resul.ToString();


            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira um valor para o raio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label5.Text = ""; textBox1.Text = "";
        }
    }
}
