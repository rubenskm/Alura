namespace Learning.Caelum
{
	public sealed class Cliente
	{
		public string Nome { get; set; }

		public string RG { get; set; }

		public string CPF { get; set; }

		public string Endereco { get; set; }

		public int Idade { get; set; }

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
	}
}
