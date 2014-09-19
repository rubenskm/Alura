using LojaWeb.DAO;
using LojaWeb.Entidades;
using LojaWeb.Infra;
using LojaWeb.Models;
using NHibernate;
using System.Collections.Generic;
using System.Web.Mvc;

namespace LojaWeb.Controllers
{
	public class CategoriasController : Controller
	{
		private CategoriasDAO dao;

		public CategoriasController(CategoriasDAO dao)
		{
			this.dao = dao;
		}
		//
		// GET: /Categorias/

		public ActionResult Index()
		{
			IList<Categoria> categorias = new List<Categoria>();
			return View(categorias);
		}

		public ActionResult Form()
		{
			return View();
		}

		public ActionResult Adiciona(Categoria categoria)
		{
			dao.Adiciona(categoria);
			return RedirectToAction("Visualiza", new { id = categoria.Id });
		}

		public ActionResult Remove(int id)
		{
	 
			return RedirectToAction("Index");
		}

		public ActionResult Visualiza(int id)
		{
			Categoria categoria = dao.BuscaPorId(id);
			return View(categoria != null ? categoria : new Categoria());
		}

		public ActionResult Atualiza(Categoria categoria)
		{
			dao.Atualiza(categoria);
			return RedirectToAction("Visualiza", new { id = categoria.Id });
		}

		public ActionResult CategoriasEProdutos()
		{
			IList<Categoria> categorias = new List<Categoria>();
			return View(categorias);
		}

		public ActionResult BuscaPorNome(string nome)
		{
			ViewBag.Nome = nome;

			IList<Categoria> categorias = new List<Categoria>();
			return View(categorias);
		}

		public ActionResult NumeroDeProdutosPorCategoria()
		{
			IList<ProdutosPorCategoria> produtosPorCategoria = new List<ProdutosPorCategoria>();
			return View(produtosPorCategoria);
		}
	}
}
