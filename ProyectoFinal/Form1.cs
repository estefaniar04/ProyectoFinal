using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int valor = 0;
        private void btnSuma_Click(object sender, EventArgs e)
        {
            valor = int.Parse(CalcularResultado.Text);
            CalcularResultado.Text = "";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            CalcularResultado.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            CalcularResultado.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            CalcularResultado.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            CalcularResultado.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            CalcularResultado.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            CalcularResultado.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            CalcularResultado.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            CalcularResultado.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            CalcularResultado.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            CalcularResultado.Text += "9";
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            valor = int.Parse(CalcularResultado.Text);
            CalcularResultado.Text = "";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            int a = valor;
            int b = int.Parse(CalcularResultado.Text);

            Operaciones operacion = new Operaciones();
            CalcularResultado.Text = operacion.Sumar(a, b) + "";

            OperacionesBinarias operacionesBinarias = new OperacionesBinarias();
            CalcularResultado.Text = operacionesBinarias.Sumar(a, b);
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            CalcularResultado.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
