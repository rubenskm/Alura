using LojaWeb.Entidades;
using NHibernate;
using System.Collections.Generic;

namespace LojaWeb.DAO
{
	public class UsuariosDAO
	{
		private ISession session;

		public UsuariosDAO(ISession session)
		{
			this.session = session;
		}

		public void Adiciona(Usuario usuario)
		{
			using (ITransaction transacao = this.session.BeginTransaction())
			{
				this.session.Save(usuario);
				transacao.Commit();
			}
		}

		public void Remove(Usuario usuario)
		{

		}

		public void Atualiza(Usuario usuario)
		{
			using (ITransaction transacao = this.session.BeginTransaction())
			{
				this.session.Merge(usuario);
				transacao.Commit();
			}
		}

		public Usuario BuscaPorId(int id)
		{
			return session.Get<Usuario>(id);
		}

		public IList<Usuario> Lista()
		{
			return new List<Usuario>();
		}
	}
}