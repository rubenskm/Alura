using System.Web.Mvc;
using CaelumEstoque.DAO;

namespace CaelumEstoque.Controllersa
{
	public class LoginController : Controller
	{
		// GET: Login
		public ActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Autentica(string login, string senha)
		{
			UsuariosDAO dao = new UsuariosDAO();
			var usuario = dao.Busca(login, senha);
			if (usuario != null)
			{
				Session["usuarioLogado"] = usuario;
				return RedirectToAction("index", "Produto");
			}
			else
			{
				return RedirectToAction("Index");
			}
		}
	}
}