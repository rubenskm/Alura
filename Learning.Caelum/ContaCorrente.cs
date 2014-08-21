using Learning.Caelum;
using System;

internal sealed class ContaCorrente : Conta
{
	public override bool Saca(double valor)
	{
		if (valor <= 0.0 || valor > this.Saldo)
			return false;

		if (this.Titular.EhMaiorDeIdade)
		{
			this.Saldo -= valor;
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
