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
    public partial class Form5_Anielly : Form


    {
        double feh, grau;
        public Form5_Anielly()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                feh = Convert.ToDouble(textBox1.Text);
                grau = (feh - 32) * 5 / 9;
                label4.Text = grau.ToString("f2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira uma temperatura em Fahrenheit:.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form5_Anielly_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label4.Text = ""; textBox1.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //Faça um algoritmo que leia uma temperatura em Fahrenheit e a apresente convertida em graus Celsius. 
            //A fórmula de conversão é C = (F – 32) * ( 5 / 9), na qual F é a temperatura em Fahrenheit e C é a temperatura em Celcius.
        }
    }
}
