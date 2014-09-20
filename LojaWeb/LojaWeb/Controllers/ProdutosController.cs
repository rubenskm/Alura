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
			IList<Produto> produtos = dao.Lista();
			return View(produtos);
		}

		public ActionResult Form()
		{
			return View();
		}

		public ActionResult Adiciona(Produto produto)
		{
			produto = CheckCategory(produto);

			dao.Adiciona(produto);
			return RedirectToAction("Visualiza", new { id = produto.Id });
		}

		private Produto CheckCategory(Produto produto)
		{
			if (produto.Categoria.Id == 0)
			{
				produto.Categoria = null;
			}
			return produto;
		}

		public ActionResult Remove(int id)
		{
			return RedirectToAction("Index");
		}

		public ActionResult Visualiza(int id)
		{
			Produto produto = dao.BuscaPorId(id);
			return View(produto != null ? produto : new Produto());
		}

		public ActionResult Atualiza(Produto produto)
		{
			produto = CheckCategory(produto);
			dao.Atualiza(produto);
			return RedirectToAction("Visualiza", new { id = produto.Id });
		}

		public ActionResult ProdutosComPrecoMinimo(double? preco)
		{
			ViewBag.Preco = preco;
			IList<Produto> produtos = dao.ProdutosComPrecoMaiorDoQue(preco);
			return View(produtos);
		}

		public ActionResult ProdutosDaCategoria(string nomeCategoria)
		{
			ViewBag.NomeCategoria = nomeCategoria;
			IList<Produto> produtos = dao.ProdutosDaCategoria(nomeCategoria);
			return View(produtos);
		}

		public ActionResult ProdutosDaCategoriaComPrecoMinimo(double? preco, string nomeCategoria)
		{
			ViewBag.Preco = preco;
			ViewBag.NomeCategoria = nomeCategoria;
			IList<Produto> produtos = dao.ProdutosDaCategoriaComPrecoMaiorDoQue(preco, nomeCategoria);
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
			IList<Produto> produtos = dao.ListaPaginada(paginaAtual);
			return View(produtos);
		}
	}
}
