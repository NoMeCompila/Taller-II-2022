using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico1
{
    public partial class Formulario1 : Form
    {
        public Formulario1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            string var1 = textBox1.Text;
            string var2 = textBox2.Text;
            string var3 = var1 + " " + var2;
            textBox3.Text = var3;
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Formulario1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode.ToString() == "S")
            {
                button1.PerformClick();
            }
        }
    }
}
