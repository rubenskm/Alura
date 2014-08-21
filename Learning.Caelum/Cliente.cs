namespace Learning.Caelum
{
	public sealed class Cliente
	{
		public string Nome { get; private set; }

		public string RG { get; private set; }

		public string CPF { get; private set; }

		public string Endereco { get; private set; }

		public int Idade { get; private set; }

		public bool EEmancipado { get; private set; }

		public bool EhMaiorDeIdade
		{
			get
			{
				return this.Idade >= 18;
			}
		}

		public Cliente(string nome)
		{
			this.Nome = nome;
		}

		public Cliente()
		{
		}

		public bool PodeAbrirConta()
		{
			return (EhMaiorDeIdade || EEmancipado) && !string.IsNullOrEmpty(CPF);
		}
	}
}
