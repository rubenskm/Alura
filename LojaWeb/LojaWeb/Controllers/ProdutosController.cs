﻿using LojaWeb.DAO;
using LojaWeb.Entidades;
using LojaWeb.Infra;
using NHibernate;
using System.Collections.Generic;
using System.Web.Mvc;

namespace LojaWeb.Controllers
{
	public class ProdutosController : Controller
	{
		private ProdutosDAO dao;

		public ProdutosController(ProdutosDAO dao)
		{
			this.dao = dao;
		}
		//
		// GET: /Produtos/

		public ActionResult Index()
		{

			IList<Produto> produtos = new List<Produto>();
			return View(produtos);
		}

		public ActionResult Form()
		{
			return View();
		}

		public ActionResult Adiciona(Produto produto)
		{
			using (ISession session = NHibernateHelper.AbreSession())
			{
				ProdutosDAO dao = new ProdutosDAO(session);
				dao.Adiciona(produto);
			}
			return RedirectToAction("Visualiza", new { id = produto.Id });
		}

		public ActionResult Remove(int id)
		{
			return RedirectToAction("Index");
		}

		public ActionResult Visualiza(int id)
		{
			Produto produto = new Produto();
			using (ISession session = NHibernateHelper.AbreSession())
			{
				ProdutosDAO dao = new ProdutosDAO(session);
				produto = dao.BuscaPorId(id);
			}

			return View(produto);
		}

		public ActionResult Atualiza(Produto produto)
		{
			using (ISession session = NHibernateHelper.AbreSession())
			{
				ProdutosDAO dao = new ProdutosDAO(session);
				dao.Atualiza(produto);
			}
			return RedirectToAction("Visualiza", new { id = produto.Id });
		}

		public ActionResult ProdutosComPrecoMinimo(double? preco)
		{
			ViewBag.Preco = preco;
			IList<Produto> produtos = new List<Produto>();
			return View(produtos);
		}

		public ActionResult ProdutosDaCategoria(string nomeCategoria)
		{
			ViewBag.NomeCategoria = nomeCategoria;
			IList<Produto> produtos = new List<Produto>();
			return View(produtos);
		}

		public ActionResult ProdutosDaCategoriaComPrecoMinimo(double? preco, string nomeCategoria)
		{
			ViewBag.Preco = preco;
			ViewBag.NomeCategoria = nomeCategoria;
			IList<Produto> produtos = new List<Produto>();
			return View(produtos);
		}

		public ActionResult BuscaDinamica(double? preco, string nome, string nomeCategoria)
		{
			ViewBag.Preco = preco;
			ViewBag.Nome = nome;
			ViewBag.NomeCategoria = nomeCategoria;

			IList<Produto> produtos = new List<Produto>();
			return View(produtos);
		}
		public ActionResult ListaPaginada(int? pagina)
		{
			int paginaAtual = pagina.GetValueOrDefault(1);
			ViewBag.Pagina = paginaAtual;
			IList<Produto> produtos = new List<Produto>();
			return View(produtos);
		}
	}
}
