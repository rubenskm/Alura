namespace Learning.Caelum
{
	internal sealed class ContaPoupanca : Conta
	{
		public override bool Saca(double valor)
		{
			if (valor <= 0.0 || valor > this.Saldo)
				return false;

			if (this.Titular.EhMaiorDeIdade)
			{
				this.Saldo -= valor + 0.1;
				return true;
			}
			else
			{
				if (valor >= 200.0)
					return false;
				this.Saldo -= valor;
				return true;
			}
		}
	}
}
