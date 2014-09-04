using CaelumEstoque.Models;
using System.Data.Entity;

namespace CaelumEstoque.DAO
{
    public class EstoqueContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }

        public DbSet<CategoriaDoProduto> Categorias { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

        
    }
}