namespace Learning.Caelum
{
	public class Banco
	{
		private Conta[] contas = new Conta[10];

		public void Adiciona(Conta conta)
		{
			this.contas[contas.Length] = conta;
		}
	}
}
