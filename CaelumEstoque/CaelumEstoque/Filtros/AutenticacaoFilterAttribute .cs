using System.Web.Mvc;
using System.Web.Routing;

namespace CaelumEstoque.Filtros
{
	public class AutenticacaoFilterAttribute : ActionFilterAttribute
	{
		public override void OnActionExecuting(ActionExecutingContext filterContext)
		{
			var usuario = filterContext.HttpContext.Session["usuariologado"];
			if (usuario == null)
			{
				filterContext.Result = new RedirectToRouteResult(
					new RouteValueDictionary(
						new { controller = "Login", action = "Index" }
					)
				);
			}
		}
	}
}