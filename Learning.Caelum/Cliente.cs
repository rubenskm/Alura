namespace Caelum.CaixaEletronico.Usuarios
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

		public override bool Equals(object obj)
		{
			Cliente cliente = (Cliente)obj;
			return this.RG.Equals(cliente.RG);
		}

		public override string ToString()
		{
			return string.Format("Cliente Nome: {0}, RG: {1}", this.Nome, this.RG);
		}
	}
}
