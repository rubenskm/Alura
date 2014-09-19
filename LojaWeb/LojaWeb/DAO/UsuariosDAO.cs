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
			this.session.Save(usuario);
		}

		public void Remove(Usuario usuario)
		{

		}

		public void Atualiza(Usuario usuario)
		{
			this.session.Merge(usuario);
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