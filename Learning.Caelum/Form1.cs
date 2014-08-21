using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Learning.Caelum
{
	public class Form1 : Form
	{
		private IContainer components = (IContainer)null;
		private Conta conta;
		private Button button1;
		private TextBox textoTitular;
		private TextBox textoSaldo;
		private TextBox textoNumero;
		private TextBox textoValor;
		private Button button2;
		private Label label1;

		public Form1()
		{
			this.InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			this.conta = new Conta();
			this.conta.Deposita(100.0);
			this.conta.Numero = 1;
			this.conta.Titular = new Cliente("João");
			this.textoSaldo.Text = Convert.ToString(this.conta.Saldo);
			this.textoNumero.Text = Convert.ToString(this.conta.Numero);
			this.textoTitular.Text = this.conta.Titular.Nome;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.conta.Deposita(Convert.ToDouble(this.textoValor.Text));
			this.textoSaldo.Text = this.conta.Saldo.ToString();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.conta.Saca(Convert.ToDouble(this.textoValor.Text));
			this.textoSaldo.Text = this.conta.Saldo.ToString();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
				this.components.Dispose();
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.textoTitular = new System.Windows.Forms.TextBox();
			this.textoSaldo = new System.Windows.Forms.TextBox();
			this.textoNumero = new System.Windows.Forms.TextBox();
			this.textoValor = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(171, 211);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Deposito";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textoTitular
			// 
			this.textoTitular.Location = new System.Drawing.Point(108, 40);
			this.textoTitular.Name = "textoTitular";
			this.textoTitular.Size = new System.Drawing.Size(100, 20);
			this.textoTitular.TabIndex = 1;
			// 
			// textoSaldo
			// 
			this.textoSaldo.Location = new System.Drawing.Point(108, 65);
			this.textoSaldo.Name = "textoSaldo";
			this.textoSaldo.Size = new System.Drawing.Size(100, 20);
			this.textoSaldo.TabIndex = 2;
			// 
			// textoNumero
			// 
			this.textoNumero.Location = new System.Drawing.Point(108, 91);
			this.textoNumero.Name = "textoNumero";
			this.textoNumero.Size = new System.Drawing.Size(100, 20);
			this.textoNumero.TabIndex = 3;
			// 
			// textoValor
			// 
			this.textoValor.Location = new System.Drawing.Point(108, 117);
			this.textoValor.Name = "textoValor";
			this.textoValor.Size = new System.Drawing.Size(100, 20);
			this.textoValor.TabIndex = 4;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(79, 211);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 5;
			this.button2.Text = "Saque";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 72);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(92, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Número da conta:";
			// 
			// Form1
			// 
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.textoValor);
			this.Controls.Add(this.textoNumero);
			this.Controls.Add(this.textoSaldo);
			this.Controls.Add(this.textoTitular);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
