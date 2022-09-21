using Armazen.Servicos;
using Microsoft.AspNetCore.Mvc;

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
    }
}
