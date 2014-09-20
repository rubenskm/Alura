using LojaWeb.Entidades;
using NHibernate;
using NHibernate.Criterion;
using System.Collections.Generic;

namespace LojaWeb.DAO
{
	public class ProdutosDAO
	{
		private ISession session;

		public ProdutosDAO(ISession session)
		{
			this.session = session;
		}

		public void Adiciona(Produto produto)
		{
			this.session.Save(produto);
		}

		public void Remove(Produto produto)
		{

		}

		public void Atualiza(Produto produto)
		{
			this.session.Merge(produto);
		}

		public Produto BuscaPorId(int id)
		{
			return session.Get<Produto>(id);
		}

		public IList<Produto> Lista()
		{
			IQuery query = session.CreateQuery("from Produto");
			return query.List<Produto>();
		}

		public IList<Produto> ProdutosComPrecoMaiorDoQue(double? preco)
		{
			IQuery query = session.CreateQuery("from Produto p where p.Preco > :preco");
			query.SetParameter("preco", preco.GetValueOrDefault(0));
			return query.List<Produto>();
		}

		public IList<Produto> ProdutosDaCategoria(string nomeCategoria)
		{
			IQuery query = session.CreateQuery("from Produto p where p.Categoria.Nome = :nomeCategoria");
			query.SetParameter("nomeCategoria", nomeCategoria);
			return query.List<Produto>();
		}

		public IList<Produto> ProdutosDaCategoriaComPrecoMaiorDoQue(double? preco, string nomeCategoria)
		{
			IQuery query = session.CreateQuery("from Produto p where p.Categoria.Nome = :nomeCategoria and p.Preco > :preco");
			query.SetParameter("nomeCategoria", nomeCategoria);
			query.SetParameter("preco", preco.GetValueOrDefault(0));
			return query.List<Produto>();
		}

		public IList<Produto> ListaPaginada(int paginaAtual)
		{
			string hql = "from Produto p order by p.Id";
			int resultadosPorPagina = 10;
			IQuery query = session.CreateQuery(hql);
			query.SetMaxResults(resultadosPorPagina);
			query.SetFirstResult(resultadosPorPagina * (paginaAtual - 1));
			return query.List<Produto>();
		}

		public IList<Produto> BuscaPorPrecoCategoriaENome(double? preco, string nomeCategoria, string nome)
		{
			ICriteria criteria = session.CreateCriteria<Produto>();

			if (preco > 0)
			{
				criteria.Add(Restrictions.Gt("Preco", preco));
			}
			
			if (!string.IsNullOrEmpty(nome))
			{
				criteria.Add(Restrictions.Eq("Nome", nome));
			}

			if (!string.IsNullOrEmpty(nomeCategoria))
			{
				ICriteria criteriaCategoria = criteria.CreateCriteria("Categoria");
				criteriaCategoria.Add(Restrictions.Eq("Nome", nomeCategoria));
			}

			return criteria.List<Produto>();
		}
	}
}