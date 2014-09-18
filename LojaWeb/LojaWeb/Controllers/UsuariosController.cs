using LojaWeb.DAO;
using LojaWeb.Entidades;
using LojaWeb.Infra;
using NHibernate;
using System.Collections.Generic;
using System.Web.Mvc;

namespace LojaWeb.Controllers
{
	public class UsuariosController : Controller
	{
		//
		// GET: /Usuarios/

		public ActionResult Index()
		{
			IList<Usuario> usuarios = new List<Usuario>();
			return View(usuarios);
		}

		public ActionResult Form()
		{
			return View();
		}

		public ActionResult Adiciona(Usuario usuario)
		{
			using (ISession session = NHibernateHelper.AbreSession())
			{
				UsuariosDAO dao = new UsuariosDAO(session);
				dao.Adiciona(usuario);
			}
			return RedirectToAction("Visualiza", new { id = usuario.Id });
		}

		public ActionResult Remove(int id)
		{
			return RedirectToAction("Index");
		}

		public ActionResult Visualiza(int id)
		{
			Usuario usuario = new Usuario();
			using (ISession session = NHibernateHelper.AbreSession())
			{
				UsuariosDAO dao = new UsuariosDAO(session);
				usuario = dao.BuscaPorId(id);
			}

			return View(usuario);
		}

		public ActionResult Atualiza(Usuario usuario)
		{
			using (ISession session = NHibernateHelper.AbreSession())
			{
				UsuariosDAO dao = new UsuariosDAO(session);
				dao.Atualiza(usuario);
			}
			return RedirectToAction("Visualiza", new { id = usuario.Id });
		}

	}
}
