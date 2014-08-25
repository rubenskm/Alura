using System;

namespace Caelum.CaixaEletronico.Contas
{
	internal sealed class ContaPoupanca : Conta, ITributavel
	{
		public override bool Saca(double valor)
		{
			if (valor <= 0.0)
				throw new ArgumentException();
			else if (valor > this.Saldo)
				throw new SaldoInsuficienteException();

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

		public double CalculaTributos()
		{
			return Saldo * 0.03;
		}

		public string ClassName
		{
			get
			{
				return "ContaPoupanca";
			}
		}
	}
}
