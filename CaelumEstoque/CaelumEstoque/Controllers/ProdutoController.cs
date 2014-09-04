using CaelumEstoque.DAO;
using CaelumEstoque.Filtros;
using CaelumEstoque.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace CaelumEstoque.Controllers
{
	[AutenticacaoFilter]
	public class ProdutoController : Controller
	{
		// GET: Produtos
		[Route("produtos", Name = "ListaProdutos")]
		public ActionResult Index()
		{
			ProdutosDAO produtosDAO = new ProdutosDAO();
			IList<Produto> produtos = produtosDAO.Lista();
			return View(produtos);
		}

		public ActionResult Form()
		{
			return Form(new Produto());
		}

		[HttpPost]
		public ActionResult Form(Produto produto)
		{
			CategoriasDAO categoriasDAO = new CategoriasDAO();
			ViewBag.Categorias = categoriasDAO.Lista();
			ViewBag.Produto = produto;
			return View("Form");
		}

		[HttpPost, ValidateAntiForgeryTokenAttribute]
		public ActionResult Adiciona(Produto produto)
		{
			if (!produto.PrecoMaiorOuIgual100())
			{
				ModelState.AddModelError("Produto.InformaticaComPrecoInvalido", "Informática com preço abaixo de 100 reais");
			}

			if (ModelState.IsValid)
			{
				ProdutosDAO produtosDAO = new ProdutosDAO();
				produtosDAO.Adiciona(produto);

				return RedirectToAction("Index", "Home");
			}
			else
			{
				return Form(produto);
			}

		}

		[Route("produtos/{id}", Name = "VisualizaProduto")]
		public ActionResult Visualiza(int id)
		{
			ProdutosDAO produtosDAO = new ProdutosDAO();
			ViewBag.Produto = produtosDAO.BuscaPorId(id);
			return View();
		}

		public ActionResult DecrementaQtd(int id)
		{
			ProdutosDAO dao = new ProdutosDAO();
			Produto produto = dao.BuscaPorId(id);
			produto.Quantidade--;
			dao.Atualiza(produto);
			return Json(produto);
		}
	}
}