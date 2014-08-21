namespace Learning.Caelum
{
	public abstract class Conta
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

		public abstract bool Saca(double valor);

		public void Transfere(double valor, Conta destino)
		{
			this.Saca(valor);
			destino.Deposita(valor);
		}
	}
}
