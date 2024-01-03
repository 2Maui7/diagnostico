using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Suma_Click(object sender, EventArgs e)
        {
            double A = Convert.ToDouble(Num1.Text);
            double B = Convert.ToDouble(Num2.Text);
            double C = A+B;
            Suma.Text = C.ToString();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btn_Resta_Click(object sender, EventArgs e)
        {
            double A = Convert.ToDouble(Num1.Text);
            double B = Convert.ToDouble(Num2.Text);
            double C = A - B;
            Resta.Text = C.ToString();
        }

        private void btn_Multiplicar_Click(object sender, EventArgs e)
        {
            double A = Convert.ToDouble(Num1.Text);
            double B = Convert.ToDouble(Num2.Text);
            double C = A * B;
            Multiplicacion.Text = C.ToString();
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            double A = Convert.ToDouble(Num1.Text);
            double B = Convert.ToDouble(Num2.Text);
            double C = A / B;
            Divicion.Text = C.ToString();
        }
    }
}
