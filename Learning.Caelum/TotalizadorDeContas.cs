namespace Learning.Caelum
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
