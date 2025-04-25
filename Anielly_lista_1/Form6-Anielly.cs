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
    public partial class Form6_Anielly : Form {

        double raio, altu, resul;


        //Faça um algoritmo que calcule e apresente o valor do volume de uma lata de óleo, utilizando a fórmula 
        //VOLUME = 3,14159 * RAIO2* ALTURA.

        public Form6_Anielly()
        {
            InitializeComponent();
        }

        private void Form6_Anielly_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label5.Text = ""; textBox1.Text = ""; textBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                raio = Convert.ToDouble(textBox2.Text);
                altu = Convert.ToDouble(textBox1.Text);
                resul = Math.PI * (raio * raio) * altu;
                label5.Text = resul.ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira um valor para o raio e para altura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
