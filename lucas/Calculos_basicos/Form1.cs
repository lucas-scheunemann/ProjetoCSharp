using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculos_basicos
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			double num1, num2, resultado;
			num1 = Convert.ToDouble(txtNumero1.Text);
			num2 = Convert.ToDouble(txtNumero2.Text);
			if (num1 % 2 == 0)
			{
				txtTipo1.Text = "par";
			}
			if (num1 % 2 == 1)
			{
				txtTipo1.Text = "impar";
			}
			if (num2 % 2 == 0)
			{
				txtTipo2.Text = "par";
			}
			if (num2 % 2 == 1)
			{
				txtTipo2.Text = "impar";
			}

			resultado = 0.0;
			resultado = num1 + num2;
			txtResultado.Text = resultado.ToString();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			double num1, num2, resultado;
			num1 = Convert.ToDouble(txtNumero1.Text);
			num2 = Convert.ToDouble(txtNumero2.Text);
			resultado = 0.0;
			resultado = num1 * num2;
			txtResultado.Text = resultado.ToString();
		}

		private void btnLimpar_Click(object sender, EventArgs e)
		{
			txtNumero1.Text = "";
			txtNumero2.Text = "";
			txtResultado.Text = "";
		}

		private void btnSubtrair_Click(object sender, EventArgs e)
		{
			double num1, num2, resultado;
			num1 = Convert.ToDouble(txtNumero1.Text);
			num2 = Convert.ToDouble(txtNumero2.Text);
			resultado = 0.0;
			resultado = num1 - num2;
			txtResultado.Text = resultado.ToString();

		}

		private void btnDividir_Click(object sender, EventArgs e)
		{
			double num1, num2, resultado;
			num1 = Convert.ToDouble(txtNumero1.Text);
			num2 = Convert.ToDouble(txtNumero2.Text);
			resultado = 0.0;
			resultado = num1 / num2;
			txtResultado.Text = resultado.ToString();
		}

		private void btnSair_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
