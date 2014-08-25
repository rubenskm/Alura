using Caelum.CaixaEletronico.Contas;
using Caelum.CaixaEletronico.Usuarios;
using System;
using System.Windows.Forms;

namespace Caelum.CaixaEletronico
{
	public partial class CadastroDeContas : Form
	{
		private Form1 aplicacaoPrincipal;
		public CadastroDeContas(Form1 aplicacaoPrincipal)
		{
			this.aplicacaoPrincipal = aplicacaoPrincipal;
			InitializeComponent();
			cboContas.Items.Add(new ContaCorrente());
			cboContas.Items.Add(new ContaPoupanca());
			this.cboContas.DisplayMember = "ClassName";

		}

		private void button1_Click(object sender, EventArgs e)
		{
			string titular = titularConta.Text;
			Cliente cliente = new Cliente(titular);
			int numero = Convert.ToInt32(numeroConta.Text);

			Conta conta = (Conta) cboContas.SelectedItem;
			conta.Titular = cliente;
			conta.Numero = numero;

			aplicacaoPrincipal.AdicionaConta(conta);
		}
	}
}
