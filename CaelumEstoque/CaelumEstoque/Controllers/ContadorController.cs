using System;
using System.Web.Mvc;

namespace CaelumEstoque.Controllers
{
	public class ContadorController : Controller
	{
		// GET: Contador
		public ActionResult Index()
		{
			var contador = Convert.ToInt32(Session["Contador"]);
			Session["Contador"] = ++contador;
			return View(contador);
		}
	}
}