﻿using System;
using System.ComponentModel.DataAnnotations;

namespace LojaRazor.Models
{
	public class Usuario
	{
		[Required]
		public String Nome { get; set; }

		[Required, EmailAddress]
		public String Email { get; set; }

		public Sexo Sexo { get; set; }

		public Estado Estado { get; set; }

		[Required, MinLength(3)]
		public String Senha { get; set; }

		[Required]
		public DateTime DataDeNascimento { get; set; }

		[Required]
		public String Endereco { get; set; }

		public String Complemento { get; set; }

		[Required, RegularExpression("\\d{5}-\\d{3}")]
		public String CEP { get; set; }

		public string Observacoes { get; set; }

		public bool RecebePromocoes { get; set; }
	}
}