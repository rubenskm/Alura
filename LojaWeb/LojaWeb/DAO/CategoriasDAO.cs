using LojaWeb.Entidades;
using LojaWeb.Models;
using NHibernate;
using System.Collections.Generic;

namespace LojaWeb.DAO
{
	public class CategoriasDAO
	{
		private ISession session;

		public CategoriasDAO(ISession session)
		{
			this.session = session;
		}

		public void Adiciona(Categoria categoria)
		{
			using (ITransaction transacao = this.session.BeginTransaction())
			{
				this.session.Save(categoria);
				transacao.Commit();
			}
		}

		public void Remove(Categoria categoria)
		{

		}

		public void Atualiza(Categoria categoria)
		{
			using (ITransaction transacao = this.session.BeginTransaction())
			{
				this.session.Merge(categoria);
				transacao.Commit();
			}
		}

		public Categoria BuscaPorId(int id)
		{
			return session.Get<Categoria>(id);
		}

		public IList<Categoria> Lista()
		{
			return new List<Categoria>();
		}

		public IList<Categoria> BuscaPorNome(string nome)
		{
			return new List<Categoria>();
		}

		public IList<ProdutosPorCategoria> ListaNumeroDeProdutosPorCategoria()
		{
			return new List<ProdutosPorCategoria>();
		}
	}

}