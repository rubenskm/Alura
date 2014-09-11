using Loja.Entidades;
using NHibernate;

namespace Loja.DAO
{
	public class ProdutoDAO
	{
		private ISession session;
		public ProdutoDAO(ISession session)
		{
			this.session = session;
		}

		public void Adiciona(Produto produto)
		{
			session.BeginTransaction();
			session.Save(produto);
			session.Transaction.Commit();
		}

		public Produto BuscaPorId(int id)
		{
			return session.Get<Produto>(id);
		}
	}
}
