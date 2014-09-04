using System;
using System.ComponentModel.DataAnnotations;

namespace CaelumEstoque.Models
{
	public class Produto
	{
		public int Id { get; set; }

		[Required, StringLengthAttribute(20, ErrorMessage="O nome do produto deve ser menor que 20 caracteres")]
		public String Nome { get; set; }

		[Range(0.00, 10000.00, ErrorMessage = "O valor deve estar entre 0,00 e 10.000,00")]
		public float Preco { get; set; }

		[Required]
		public CategoriaDoProduto Categoria { get; set; }

		[Required]
		public int? CategoriaId { get; set; }

		[Required]
		public String Descricao { get; set; }

		[Required]
		public int Quantidade { get; set; }

		public bool PrecoMaiorOuIgual100()
		{
			int idDaInformatica = 1;
			if (CategoriaId == idDaInformatica && Preco < 100)
			{
				return false;
			}
			else
			{
				return true;
			}
		}
	}
}