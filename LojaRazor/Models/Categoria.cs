﻿
namespace LojaRazor.Models
{
    public class Categoria
    {
        public string Nome { get; set; }

        public Categoria(string nome)
        {
            this.Nome = nome;
        }
    }
}
