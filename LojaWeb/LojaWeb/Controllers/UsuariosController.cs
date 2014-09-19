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
		private UsuariosDAO dao;

		public UsuariosController(UsuariosDAO dao)
		{
			this.dao = dao;
		}
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
			dao.Adiciona(usuario);	
			return RedirectToAction("Visualiza", new { id = usuario.Id });
		}

		public ActionResult Remove(int id)
		{
			return RedirectToAction("Index");
		}

		public ActionResult Visualiza(int id)
		{
			Usuario usuario = dao.BuscaPorId(id);
			return View(usuario != null ? usuario : new Usuario());
		}

		public ActionResult Atualiza(Usuario usuario)
		{
			dao.Atualiza(usuario);
			return RedirectToAction("Visualiza", new { id = usuario.Id });
		}

	}
}
