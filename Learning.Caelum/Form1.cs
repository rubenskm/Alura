using Caelum.CaixaEletronico.Contas;
using Caelum.CaixaEletronico.Usuarios;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Caelum.CaixaEletronico
{
	public partial class Form1 : Form
	{
		private IList<Conta> contas = new List<Conta>();

		public Form1()
		{
			InitializeComponent();

			this.comboContas.DisplayMember = "Numero";
			this.destinoDaTrans.DisplayMember = "Numero";

			AdicionarConta(100, 1, "João");
			AdicionarConta(200, 2, "Mário");

			comboContas.SelectedIndex = 0;
			destinoDaTrans.SelectedIndex = 1;
			textoValor.Text = "1";
			AtualizarValoresExibidos(contas[0]);
		}

		private void AtualizarValoresExibidos(Conta conta)
		{
			this.textoSaldo.Text = Convert.ToString(conta.Saldo);
			this.textoNumero.Text = Convert.ToString(conta.Numero);
			this.textoTitular.Text = conta.Titular.Nome;
		}

		private void AdicionarConta(double valorDepositar, int numero, string nomeTitular)
		{
			Conta conta = new ContaCorrente();
			conta.Deposita(valorDepositar);
			conta.Numero = numero;
			conta.Titular = new Cliente(nomeTitular);
			AdicionaConta(conta);
		}

		private Conta BuscaContaSelecionada()
		{
			return (Conta)comboContas.SelectedItem;
		}

		private void TransferenciaBtn_Click(object sender, EventArgs e)
		{
			Conta conta = BuscaContaSelecionada();
			double valorTransferencia = Convert.ToDouble(textoValor.Text);
			conta.Transfere(valorTransferencia, contas[destinoDaTrans.SelectedIndex]);
			AtualizarValoresExibidos(conta);
		}

		private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
		{
			Conta conta =(Conta) comboContas.SelectedItem;
			AtualizarValoresExibidos(conta);
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

		private void DepositoBtn_Click(object sender, EventArgs e)
		{
			double valorDeposito = Convert.ToDouble(textoValor.Text);
			Conta contaSelecionada = this.BuscaContaSelecionada();
			contaSelecionada.Deposita(valorDeposito);
			AtualizarValoresExibidos(contaSelecionada);
		}

		public void AdicionaConta(Conta conta)
		{
			contas.Add(conta);

			comboContas.Items.Add(conta);
			destinoDaTrans.Items.Add(conta);
		}

		private void RemoverConta(Conta conta)
		{
			contas.Remove(conta);

			comboContas.Items.Remove(conta);
			destinoDaTrans.Items.Remove(conta);
			comboContas.SelectedIndex = 0;
		}

		private void cadastrarBtn_Click(object sender, EventArgs e)
		{
			CadastroDeContas cadastroDeContas = new CadastroDeContas(this);
			cadastroDeContas.ShowDialog();
		}

		private void btnRemover_Click(object sender, EventArgs e)
		{
			RemoverConta((Conta)comboContas.SelectedItem);
		}
	}
}
