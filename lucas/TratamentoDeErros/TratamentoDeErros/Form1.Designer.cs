namespace TratamentoDeErros
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
			this.btnCalcular = new System.Windows.Forms.Button();
			this.titulo = new System.Windows.Forms.Label();
			this.txtValor1 = new System.Windows.Forms.TextBox();
			this.txtValor2 = new System.Windows.Forms.TextBox();
			this.txtResultado = new System.Windows.Forms.TextBox();
			this.sinalDeMais = new System.Windows.Forms.Label();
			this.sinalDeIgual = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnCalcular
			// 
			this.btnCalcular.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCalcular.Location = new System.Drawing.Point(120, 195);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(170, 62);
			this.btnCalcular.TabIndex = 0;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
			// 
			// titulo
			// 
			this.titulo.AutoSize = true;
			this.titulo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.titulo.Location = new System.Drawing.Point(169, 44);
			this.titulo.Name = "titulo";
			this.titulo.Size = new System.Drawing.Size(72, 24);
			this.titulo.TabIndex = 1;
			this.titulo.Text = "SOMA";
			// 
			// txtValor1
			// 
			this.txtValor1.Location = new System.Drawing.Point(12, 131);
			this.txtValor1.Name = "txtValor1";
			this.txtValor1.Size = new System.Drawing.Size(100, 20);
			this.txtValor1.TabIndex = 2;
			// 
			// txtValor2
			// 
			this.txtValor2.Location = new System.Drawing.Point(141, 131);
			this.txtValor2.Name = "txtValor2";
			this.txtValor2.Size = new System.Drawing.Size(100, 20);
			this.txtValor2.TabIndex = 3;
			// 
			// txtResultado
			// 
			this.txtResultado.Location = new System.Drawing.Point(275, 131);
			this.txtResultado.Name = "txtResultado";
			this.txtResultado.Size = new System.Drawing.Size(100, 20);
			this.txtResultado.TabIndex = 4;
			// 
			// sinalDeMais
			// 
			this.sinalDeMais.AutoSize = true;
			this.sinalDeMais.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.sinalDeMais.Location = new System.Drawing.Point(118, 131);
			this.sinalDeMais.Name = "sinalDeMais";
			this.sinalDeMais.Size = new System.Drawing.Size(22, 24);
			this.sinalDeMais.TabIndex = 5;
			this.sinalDeMais.Text = "+";
			// 
			// sinalDeIgual
			// 
			this.sinalDeIgual.AutoSize = true;
			this.sinalDeIgual.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.sinalDeIgual.Location = new System.Drawing.Point(247, 131);
			this.sinalDeIgual.Name = "sinalDeIgual";
			this.sinalDeIgual.Size = new System.Drawing.Size(22, 24);
			this.sinalDeIgual.TabIndex = 6;
			this.sinalDeIgual.Text = "=";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(431, 313);
			this.Controls.Add(this.sinalDeIgual);
			this.Controls.Add(this.sinalDeMais);
			this.Controls.Add(this.txtResultado);
			this.Controls.Add(this.txtValor2);
			this.Controls.Add(this.txtValor1);
			this.Controls.Add(this.titulo);
			this.Controls.Add(this.btnCalcular);
			this.Name = "Form1";
			this.Text = "Tratamento de Erros";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.Label titulo;
		private System.Windows.Forms.TextBox txtValor1;
		private System.Windows.Forms.TextBox txtValor2;
		private System.Windows.Forms.TextBox txtResultado;
		private System.Windows.Forms.Label sinalDeMais;
		private System.Windows.Forms.Label sinalDeIgual;
	}
}

