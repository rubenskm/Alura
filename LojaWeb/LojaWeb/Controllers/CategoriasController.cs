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
			using (ISession session = NHibernateHelper.AbreSession())
			{
				CategoriasDAO dao = new CategoriasDAO(session);
				dao.Adiciona(categoria);
			}
			return RedirectToAction("Visualiza", new { id = categoria.Id });
		}

		public ActionResult Remove(int id)
		{
	 
			return RedirectToAction("Index");
		}

		public ActionResult Visualiza(int id)
		{
			Categoria categoria = new Categoria();
			using (ISession session = NHibernateHelper.AbreSession())
			{
				CategoriasDAO dao = new CategoriasDAO(session);
				categoria = dao.BuscaPorId(id);
			}

			return View(categoria);
		}

		public ActionResult Atualiza(Categoria categoria)
		{
			using (ISession session = NHibernateHelper.AbreSession())
			{
				CategoriasDAO dao = new CategoriasDAO(session);
				dao.Atualiza(categoria);
			}
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
