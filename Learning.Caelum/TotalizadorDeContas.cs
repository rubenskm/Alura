using Caelum.CaixaEletronico.Contas;

namespace Caelum.CaixaEletronico.Totalizador
{
	class TotalizadorDeContas
	{
		public double SaldoTotal {  get; private set; }

		public void Adiciona (Conta conta)
		{
			SaldoTotal += conta.Saldo;
		}
	}
}
