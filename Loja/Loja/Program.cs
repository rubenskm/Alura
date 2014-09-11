
using Loja.Entidades;
using Loja.Infra;
using NHibernate;
using System;
namespace Loja
{
	class Program
	{
		static void Main(string[] args)
		{
			//NHibernateHelper.GeraSchema();

			Produto produto = new Produto();
			produto.Nome = "Teclado";
			produto.Preco = 20.0;

			using(ISession session = NHibernateHelper.AbreSession())
			{
				session.BeginTransaction();
				session.Save(produto);
				session.Transaction.Commit();
			}

			Console.Read();
		}
	}
}
