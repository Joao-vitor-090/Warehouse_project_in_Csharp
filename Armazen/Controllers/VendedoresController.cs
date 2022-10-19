using Armazen.Servicos;
using Microsoft.AspNetCore.Mvc;
using  Armazen.Models;

namespace Armazen.Controllers
{
    public class VendedoresController : Controller
    {
        private readonly VendeddorServicos _vendeddorServicos;
        private readonly DepositoServicos _depositoServicos;

        public VendedoresController(VendeddorServicos vendeddorServico,DepositoServicos depositoServicos)
        {
            _vendeddorServicos = vendeddorServico;
            _depositoServicos = depositoServicos;//injeção de dependência 
        }
        public IActionResult Index()
        {
            var list = _vendeddorServicos.ReqTodos();
            return View(list);
        }

      public IActionResult Criar()//tipo de retorno de todas as ações
        {
            var Depositos = _depositoServicos.FindAll(); //para buscar no banco de dados todos os departamentos
            var ViewModel = new VendedorFormViewModel { Depositos = Depositos };

            return View(ViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken] //Para evitar que a aplicação sofra ataques csrf
        public IActionResult Criar(Vendedor vendedor)
        {
            _vendeddorServicos.Enviar(vendedor);
            return RedirectToAction(nameof(Index));

        }
        public IActionResult Deletar(int? id) //int opcional
        {
            if (id == null)
            {
                return NotFound();
            }
            var obj = _vendeddorServicos.ReqParaId(id.Value);
            if (obj == null)
            {

                return NotFound();
            }
            return View(obj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken] 
        public IActionResult Deletar(int id)
        {
            _vendeddorServicos.Remove(id);
            return RedirectToAction(nameof(Index));
        }

       public IActionResult Detalhes (int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var obj = _vendeddorServicos.ReqParaId(id.Value);

            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
    }
}
