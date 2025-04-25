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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Anielly_lista_1
{
    public partial class Form11_Anielly : Form
    {

        double num, numqa, numcb;
        public Form11_Anielly()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label6.Text = ""; label7.Text = ""; textBox2.Text = "";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //11. Faça um algoritmo que leia um valor inteiro e apresente os resultados do quadrado e do cubo do valor lido.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                num = Convert.ToDouble(textBox2.Text);
                numqa = num * num;
                label6.Text = numqa.ToString("");
                numcb = num * num * num;
                label7.Text = numcb.ToString("");

            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira um valor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
