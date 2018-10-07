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
    public partial class CalculadoraFrm : Form
    {
        double numero1;
        double numero2;
        string operador;

        public CalculadoraFrm()
        {
            InitializeComponent();
        }


        Calculadora calculadora= new Calculadora();

        private void button1_Click(object sender, EventArgs e)
        {
            operador = "+";
            numero1 = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            operador = "-";
            numero1 = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            operador = "/";
            numero1 = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            operador = "*";
            numero1 = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

      
        private void button16_Click(object sender, EventArgs e)
        {
            numero2 = double.Parse(textBox1.Text);
            double suma;
            double resta;
            double division;
            double multiplicar;
            switch (operador)
            {
                case "+": suma =       calculadora.operaciones(operador, numero1, numero2);
                    textBox1.Text = suma.ToString();
                    break;
                case "-": resta=calculadora.operaciones(operador, numero1, numero2);
                    textBox1.Text = resta.ToString();
                    break;
                case "/":
                    division= calculadora.operaciones(operador, numero1, numero2);
                    textBox1.Text = division.ToString();
                    break;
                case "*":
                    multiplicar= calculadora.operaciones(operador, numero1, numero2);
                    textBox1.Text = multiplicar.ToString();
                    break;
            }


        }

        private void CalculadoraFrm_Load(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            numero1 = 0.0;
            numero2 = 0.0;
            textBox1.Clear();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 1)
                textBox1.Text = "";
            else
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)46) && (e.KeyChar != (char)45))
            {
                /*MessageBox.Show("Digite numeros", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);*/
                Validacion validacion = new Validacion();
                validacion.ShowDialog();
                e.Handled = true;
                return;

            }
        }
    }
}
