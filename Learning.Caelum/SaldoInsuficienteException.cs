using System;

namespace Caelum.CaixaEletronico
{
	class SaldoInsuficienteException : Exception
	{
		public SaldoInsuficienteException()
			: base("Saldo insuficiente")
		{

		}
	}
}
