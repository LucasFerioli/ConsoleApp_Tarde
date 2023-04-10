using System.Collections.Generic;
using System.Web.Mvc;

namespace MinhaAplicacao.Controllers
{
    public class ProdutosController : Controller
    {
        // Método para obter a lista de produtos
        public ActionResult Lista()
        {
            List<Produto> produtos = new List<Produto>();
            // Adicionar produtos à lista
            return View(produtos);
        }

        // Método para cadastrar um novo produto
        public ActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastro(Produto produto)
        {
            // Salvar o produto no banco de dados
            return RedirectToAction("Lista");
        }
    }

    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
    }
}
