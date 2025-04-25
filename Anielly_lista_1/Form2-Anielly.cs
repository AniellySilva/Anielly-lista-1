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
    public partial class Form2_Anielly : Form

    {
        double saliq, salbru, desc, valhor, hortra, perdesc, totaldesc;

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label5.Text = ""; textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = "";
        }

        public Form2_Anielly()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                valhor = Convert.ToDouble(textBox2.Text);
                hortra = Convert.ToDouble(textBox1.Text);
                perdesc = Convert.ToDouble(textBox3.Text);
                salbru = hortra * valhor;
                totaldesc = perdesc / 100 * salbru;
                saliq = salbru - totaldesc;
                label5.Text = saliq.ToString("F2");

            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira valores válidos para horas trabalhadas, valor da hora e percentual de desconto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
