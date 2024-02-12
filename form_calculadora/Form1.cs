using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_Valor1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btn_Calcularr_Click_1(object sender, EventArgs e)
        {
            double valor1, valor2, Suma, Resta, Multiplicacion, Division;

            valor1 = double.Parse(txt_Valorr1.Text);
            valor2 = double.Parse(txt_Valorr2.Text);

            Suma = valor1 + valor2;
            Resta = valor1 - valor2;
            Multiplicacion = valor2 * valor1;
            Division = valor1 / valor2;


            txt_Sumas.Text = Suma.ToString();
            txt_Restas.Text = Resta.ToString();
            txt_Multiplicaciones.Text = Multiplicacion.ToString();
            txt_Divisiones.Text = Division.ToString();
        }

        private void btn_Limpiarr_Click(object sender, EventArgs e)
        {
            txt_Sumas.Clear();
            txt_Restas.Clear();
            txt_Multiplicaciones.Clear();
            txt_Divisiones.Clear();
        }

        private void btn_Salirr_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
