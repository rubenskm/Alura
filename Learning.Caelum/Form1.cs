using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Caelum.CaixaEletronico.Contas;
using Caelum.CaixaEletronico.Banco;
using Caelum.CaixaEletronico.Usuarios;

namespace Caelum.CaixaEletronico
{
	public class Form1 : Form
	{
		private IContainer components = (IContainer)null;
		private Button DepositoBtn;
		private TextBox textoTitular;
		private TextBox textoSaldo;
		private TextBox textoNumero;
		private TextBox textoValor;
		private Button SaqueBtn;
		private ComboBox comboContas;
		private Label label1;

		private Conta[] contas = new Conta[10];
		private ComboBox destinoDaTrans;
		private Label label2;
		private Button TransferenciaBtn;
		private int quantidade = 0;

		public Form1()
		{
			this.InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			contas = AdicionarConta(contas, 100, 1, "João");
			contas = AdicionarConta(contas, 200, 1, "Mário");

			for (int i = 0; i < 2; i++)
			{
				comboContas.Items.Add(contas[i]);
				destinoDaTrans.Items.Add(contas[i]);
			}

			comboContas.SelectedIndex = 0;
			destinoDaTrans.SelectedIndex = 1;
			textoValor.Text = "1";
			AtualizarValoresExibidos(contas[0]);

			ContaInvestimento c1 = new ContaInvestimento();
			ContaPoupanca co = new ContaPoupanca();

		}

		private void AtualizarValoresExibidos(Conta conta)
		{
			this.textoSaldo.Text = Convert.ToString(conta.Saldo);
			this.textoNumero.Text = Convert.ToString(conta.Numero);
			this.textoTitular.Text = conta.Titular.Nome;
		}

		private Conta[] AdicionarConta(Conta[] contas, double valorDepositar, int numero, string nomeTitular)
		{
			Conta conta = new ContaCorrente();
			conta.Deposita(valorDepositar);
			conta.Numero = numero;
			conta.Titular = new Cliente(nomeTitular);
			contas[quantidade++] = conta;

			return contas;
		}

		private void DepositoBtn_Click(object sender, EventArgs e)
		{
			double valorDeposito = Convert.ToDouble(textoValor.Text);
			Conta contaSelecionada = this.BuscaContaSelecionada();
			contaSelecionada.Deposita(valorDeposito);
			AtualizarValoresExibidos(contaSelecionada);
		}

		private Conta BuscaContaSelecionada()
		{
			return contas[comboContas.SelectedIndex];
		}

		private void SaqueBtn_Click(object sender, EventArgs e)
		{
			try
			{
				double valorSaque = Convert.ToDouble(textoValor.Text);
				Conta contaSelecionada = this.BuscaContaSelecionada();
				contaSelecionada.Saca(valorSaque);
				AtualizarValoresExibidos(contaSelecionada);
			}
			catch (ArgumentException exception)
			{
				MessageBox.Show(String.Format("Valor a ser sacado inválido!, {0}"), exception.Message);
			}
			catch (SaldoInsuficienteException exception)
			{
				MessageBox.Show(exception.Message);
			}

		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
				this.components.Dispose();
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.DepositoBtn = new System.Windows.Forms.Button();
			this.textoTitular = new System.Windows.Forms.TextBox();
			this.textoSaldo = new System.Windows.Forms.TextBox();
			this.textoNumero = new System.Windows.Forms.TextBox();
			this.textoValor = new System.Windows.Forms.TextBox();
			this.SaqueBtn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.comboContas = new System.Windows.Forms.ComboBox();
			this.destinoDaTrans = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.TransferenciaBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// DepositoBtn
			// 
			this.DepositoBtn.Location = new System.Drawing.Point(197, 211);
			this.DepositoBtn.Name = "DepositoBtn";
			this.DepositoBtn.Size = new System.Drawing.Size(75, 23);
			this.DepositoBtn.TabIndex = 0;
			this.DepositoBtn.Text = "Deposito";
			this.DepositoBtn.UseVisualStyleBackColor = true;
			this.DepositoBtn.Click += new System.EventHandler(this.DepositoBtn_Click);
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
			// SaqueBtn
			// 
			this.SaqueBtn.Location = new System.Drawing.Point(108, 211);
			this.SaqueBtn.Name = "SaqueBtn";
			this.SaqueBtn.Size = new System.Drawing.Size(75, 23);
			this.SaqueBtn.TabIndex = 5;
			this.SaqueBtn.Text = "Saque";
			this.SaqueBtn.UseVisualStyleBackColor = true;
			this.SaqueBtn.Click += new System.EventHandler(this.SaqueBtn_Click);
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
			// comboContas
			// 
			this.comboContas.DisplayMember = "Nome";
			this.comboContas.FormattingEnabled = true;
			this.comboContas.Location = new System.Drawing.Point(108, 12);
			this.comboContas.Name = "comboContas";
			this.comboContas.Size = new System.Drawing.Size(147, 21);
			this.comboContas.TabIndex = 7;
			this.comboContas.SelectedIndexChanged += new System.EventHandler(this.comboContas_SelectedIndexChanged);
			// 
			// destinoDaTrans
			// 
			this.destinoDaTrans.DisplayMember = "Nome";
			this.destinoDaTrans.FormattingEnabled = true;
			this.destinoDaTrans.Location = new System.Drawing.Point(108, 144);
			this.destinoDaTrans.Name = "destinoDaTrans";
			this.destinoDaTrans.Size = new System.Drawing.Size(147, 21);
			this.destinoDaTrans.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(16, 144);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(74, 13);
			this.label2.TabIndex = 9;
			this.label2.Text = "Conta Destino";
			// 
			// TransferenciaBtn
			// 
			this.TransferenciaBtn.Location = new System.Drawing.Point(12, 211);
			this.TransferenciaBtn.Name = "TransferenciaBtn";
			this.TransferenciaBtn.Size = new System.Drawing.Size(90, 23);
			this.TransferenciaBtn.TabIndex = 10;
			this.TransferenciaBtn.Text = "Transferência";
			this.TransferenciaBtn.UseVisualStyleBackColor = true;
			this.TransferenciaBtn.Click += new System.EventHandler(this.TransferenciaBtn_Click);
			// 
			// Form1
			// 
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.TransferenciaBtn);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.destinoDaTrans);
			this.Controls.Add(this.comboContas);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.SaqueBtn);
			this.Controls.Add(this.textoValor);
			this.Controls.Add(this.textoNumero);
			this.Controls.Add(this.textoSaldo);
			this.Controls.Add(this.textoTitular);
			this.Controls.Add(this.DepositoBtn);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
		{
			Conta conta = contas[comboContas.SelectedIndex];
			AtualizarValoresExibidos(conta);
		}

		private void TransferenciaBtn_Click(object sender, EventArgs e)
		{
			Conta conta = BuscaContaSelecionada();
			double valorTransferencia = Convert.ToDouble(textoValor.Text);
			conta.Transfere(valorTransferencia, contas[destinoDaTrans.SelectedIndex]);
			AtualizarValoresExibidos(conta);
		}
	}
}
