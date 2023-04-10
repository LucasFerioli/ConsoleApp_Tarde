using System.Collections.Generic;
using System.Web.Mvc;

namespace MinhaAplicacao.Controllers
{
    public class FornecedoresController : Controller
    {
        // Método para obter a lista de fornecedores
        public ActionResult Lista()
        {
            List<Fornecedor> fornecedores = new List<Fornecedor>();
            // Adicionar fornecedores à lista
            return View(fornecedores);
        }

        // Método para cadastrar um novo fornecedor
        public ActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastro(Fornecedor fornecedor)
        {
            // Salvar o fornecedor no banco de dados
            return RedirectToAction("Lista");
        }
    }

    public class Fornecedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
    }
}
