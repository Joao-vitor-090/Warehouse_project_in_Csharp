using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Armazen.Models;

namespace Armazen.Controllers
{
    public class DepositoController : Controller
    {
        public IActionResult Index()
        {
            
            List<Deposito> list = new List<Deposito>();

            list.Add(new Deposito { Id = 0, Name = "Fashion" });
            list.Add(new Deposito { Id = 1, Name = "Eletronic"});
            return View(list);
        }
    }
}
