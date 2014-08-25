using System;

namespace Caelum.CaixaEletronico.Contas
{
	internal sealed class ContaCorrente : Conta
	{
		public override bool Saca(double valor)
		{
			if (valor <= 0.0)
				throw new ArgumentException();
			else if (valor > this.Saldo)
				throw new SaldoInsuficienteException();

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

		public string ClassName 
		{  
			get 
			{
				return "ContaCorrente";
			}
		}
	}
}
