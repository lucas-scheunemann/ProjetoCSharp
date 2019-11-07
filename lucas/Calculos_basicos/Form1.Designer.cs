namespace Calculos_basicos
{
	partial class Form1
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnSomar = new System.Windows.Forms.Button();
			this.btnMultiplicar = new System.Windows.Forms.Button();
			this.btnSubtrair = new System.Windows.Forms.Button();
			this.btnDividir = new System.Windows.Forms.Button();
			this.txtNumero1 = new System.Windows.Forms.TextBox();
			this.txtNumero2 = new System.Windows.Forms.TextBox();
			this.txtResultado = new System.Windows.Forms.TextBox();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.btnSair = new System.Windows.Forms.Button();
			this.txtTipo1 = new System.Windows.Forms.TextBox();
			this.txtTipo2 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(199, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(86, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Calculos basicos";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(89, 51);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "1° número";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(89, 100);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "2° numero";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(94, 260);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(50, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "resultado";
			// 
			// btnSomar
			// 
			this.btnSomar.BackColor = System.Drawing.Color.Chartreuse;
			this.btnSomar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOliveGreen;
			this.btnSomar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
			this.btnSomar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSomar.Location = new System.Drawing.Point(149, 150);
			this.btnSomar.Name = "btnSomar";
			this.btnSomar.Size = new System.Drawing.Size(97, 45);
			this.btnSomar.TabIndex = 4;
			this.btnSomar.Text = "Somar";
			this.btnSomar.UseVisualStyleBackColor = false;
			this.btnSomar.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnMultiplicar
			// 
			this.btnMultiplicar.BackColor = System.Drawing.Color.Chartreuse;
			this.btnMultiplicar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOliveGreen;
			this.btnMultiplicar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
			this.btnMultiplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMultiplicar.Location = new System.Drawing.Point(149, 201);
			this.btnMultiplicar.Name = "btnMultiplicar";
			this.btnMultiplicar.Size = new System.Drawing.Size(97, 38);
			this.btnMultiplicar.TabIndex = 5;
			this.btnMultiplicar.Text = "Multiplicar";
			this.btnMultiplicar.UseVisualStyleBackColor = false;
			this.btnMultiplicar.Click += new System.EventHandler(this.button2_Click);
			// 
			// btnSubtrair
			// 
			this.btnSubtrair.BackColor = System.Drawing.Color.Chartreuse;
			this.btnSubtrair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOliveGreen;
			this.btnSubtrair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
			this.btnSubtrair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSubtrair.Location = new System.Drawing.Point(252, 150);
			this.btnSubtrair.Name = "btnSubtrair";
			this.btnSubtrair.Size = new System.Drawing.Size(90, 45);
			this.btnSubtrair.TabIndex = 6;
			this.btnSubtrair.Text = "Subtrair";
			this.btnSubtrair.UseVisualStyleBackColor = false;
			this.btnSubtrair.Click += new System.EventHandler(this.btnSubtrair_Click);
			// 
			// btnDividir
			// 
			this.btnDividir.BackColor = System.Drawing.Color.Chartreuse;
			this.btnDividir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOliveGreen;
			this.btnDividir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
			this.btnDividir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDividir.Location = new System.Drawing.Point(252, 201);
			this.btnDividir.Name = "btnDividir";
			this.btnDividir.Size = new System.Drawing.Size(90, 38);
			this.btnDividir.TabIndex = 7;
			this.btnDividir.Text = "Dividir";
			this.btnDividir.UseVisualStyleBackColor = false;
			this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
			// 
			// txtNumero1
			// 
			this.txtNumero1.Location = new System.Drawing.Point(150, 48);
			this.txtNumero1.Name = "txtNumero1";
			this.txtNumero1.Size = new System.Drawing.Size(193, 20);
			this.txtNumero1.TabIndex = 8;
			// 
			// txtNumero2
			// 
			this.txtNumero2.Location = new System.Drawing.Point(150, 100);
			this.txtNumero2.Name = "txtNumero2";
			this.txtNumero2.Size = new System.Drawing.Size(193, 20);
			this.txtNumero2.TabIndex = 9;
			// 
			// txtResultado
			// 
			this.txtResultado.Location = new System.Drawing.Point(150, 257);
			this.txtResultado.Name = "txtResultado";
			this.txtResultado.Size = new System.Drawing.Size(192, 20);
			this.txtResultado.TabIndex = 10;
			// 
			// btnLimpar
			// 
			this.btnLimpar.BackColor = System.Drawing.Color.Chartreuse;
			this.btnLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
			this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLimpar.Location = new System.Drawing.Point(348, 88);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(75, 56);
			this.btnLimpar.TabIndex = 11;
			this.btnLimpar.Text = "Limpar";
			this.btnLimpar.UseVisualStyleBackColor = false;
			this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
			// 
			// btnSair
			// 
			this.btnSair.BackColor = System.Drawing.Color.Maroon;
			this.btnSair.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnSair.Location = new System.Drawing.Point(348, 294);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(75, 23);
			this.btnSair.TabIndex = 12;
			this.btnSair.Text = "Sair";
			this.btnSair.UseVisualStyleBackColor = false;
			this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
			// 
			// txtTipo1
			// 
			this.txtTipo1.Location = new System.Drawing.Point(150, 74);
			this.txtTipo1.Name = "txtTipo1";
			this.txtTipo1.Size = new System.Drawing.Size(100, 20);
			this.txtTipo1.TabIndex = 13;
			// 
			// txtTipo2
			// 
			this.txtTipo2.Location = new System.Drawing.Point(150, 124);
			this.txtTipo2.Name = "txtTipo2";
			this.txtTipo2.Size = new System.Drawing.Size(100, 20);
			this.txtTipo2.TabIndex = 14;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(109, 77);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(24, 13);
			this.label5.TabIndex = 15;
			this.label5.Text = "tipo";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(109, 127);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(24, 13);
			this.label6.TabIndex = 16;
			this.label6.Text = "tipo";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(459, 386);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtTipo2);
			this.Controls.Add(this.txtTipo1);
			this.Controls.Add(this.btnSair);
			this.Controls.Add(this.btnLimpar);
			this.Controls.Add(this.txtResultado);
			this.Controls.Add(this.txtNumero2);
			this.Controls.Add(this.txtNumero1);
			this.Controls.Add(this.btnDividir);
			this.Controls.Add(this.btnSubtrair);
			this.Controls.Add(this.btnMultiplicar);
			this.Controls.Add(this.btnSomar);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.Name = "Form1";
			this.Text = "Calculadora básica";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnSomar;
		private System.Windows.Forms.Button btnMultiplicar;
		private System.Windows.Forms.Button btnSubtrair;
		private System.Windows.Forms.Button btnDividir;
		private System.Windows.Forms.TextBox txtNumero1;
		private System.Windows.Forms.TextBox txtNumero2;
		private System.Windows.Forms.TextBox txtResultado;
		private System.Windows.Forms.Button btnLimpar;
		private System.Windows.Forms.Button btnSair;
		private System.Windows.Forms.TextBox txtTipo1;
		private System.Windows.Forms.TextBox txtTipo2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
	}
}

