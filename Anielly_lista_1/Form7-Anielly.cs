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
    public partial class Form7_Anielly : Form
    {

        double temp, vel, dis, lius;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                temp = Convert.ToDouble(textBox1.Text);
                vel = Convert.ToDouble(textBox2.Text);
                dis = temp * vel;
                label10.Text = dis.ToString();
                lius = dis / 12;
                label5.Text = lius.ToString();
                label11.Text = temp.ToString();
                label12.Text = vel.ToString();

            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira um valor para tempo e velocidade.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label5.Text = ""; label10.Text = ""; label11.Text = ""; label12.Text = ""; textBox1.Text = ""; textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form7_Anielly_Load(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        public Form7_Anielly()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            //Faça um algoritmo que calcule a quantidade de litros de combustível gasta em uma viagem, utilizando um
            //automóvel que faz 12Km por litro. Para obter o cálculo, o usuário deve fornecer o tempo gasto na viagem e a
            //velocidade média durante ela. Desta forma, será possível obter a distância percorrida com a fórmula DISTANCIA
            //= TEMPO * VELOCIDADE. Tendo o valor da distância, basta calcular a quantidade de litros de combustível
            //utilizada na viagem com a fórmula: LITROS_USADOS = DISTANCIA / 12. O programa deve apresentar os valores 
            //da velocidade média, tempo gasto na viagem, a distância percorrida e a quantidade de litros utilizada na viagem.
        }
    }
}
