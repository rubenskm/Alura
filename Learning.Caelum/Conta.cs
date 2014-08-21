namespace Learning.Caelum
{
	public class Conta
	{
		public int Numero { get; set; }

		public Cliente Titular { get; set; }

		public double Saldo { get; protected set; }

		public string CPF { get; set; }

		public int Agencia { get; set; }


		public void Deposita(double valor)
		{
			this.Saldo += valor;
		}

		public virtual bool Saca(double valor)
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

		public void Transfere(double valor, Conta destino)
		{
			this.Saca(valor);
			destino.Deposita(valor);
		}
	}
}
