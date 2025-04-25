using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anielly_lista_1
{
    public partial class Form3_Anielly : Form
    {
        double gra, feh;
        public Form3_Anielly()
        {
            InitializeComponent();
        }

        private void Form3_Anielly_Load(object sender, EventArgs e)
        {
            //Faça um algoritmo que leia uma temperatura em graus Celsius e apresente-a convertida em graus Fahrenheit. 
            //A fórmula de conversão é: F = (9 * C + 160) / 5, na qual F é a temperatura em Fahrenheit e C é a temperatura em Celsius;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label4.Text = ""; textBox1.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                gra = Convert.ToDouble(textBox1.Text);
                feh = (9 * gra + 160) / 5;
                label4.Text = feh.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira uma temperatura em graus Celsius.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
