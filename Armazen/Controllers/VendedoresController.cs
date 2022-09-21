using Armazen.Servicos;
using Microsoft.AspNetCore.Mvc;
using  Armazen.Models;

namespace Armazen.Controllers
{
    public class VendedoresController : Controller
    {
        private readonly VendeddorServicos _vendeddorServicos;

        public VendedoresController(VendeddorServicos vendeddorServico)
        {
            _vendeddorServicos = vendeddorServico; //injeção de dependência 
        }
        public IActionResult Index()
        {
            var list = _vendeddorServicos.ReqTodos();
            return View(list);
        }

      public IActionResult Criar()//tipo de retorno de todas as ações
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken] //Para evitar que a aplicação sofra ataques csrf
        public IActionResult Criar(Models.Vendedor vendedor)
        {
            _vendeddorServicos.Enviar(vendedor);
            return RedirectToAction(nameof(Index));

        }
            
    }
}
