using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Armazen.Data;
using Armazen.Models;

namespace Armazen.Controllers
{
    public class DepositoesController : Controller
    {

        private readonly ArmazenContext _context;

        public DepositoesController(ArmazenContext context)
        {
            _context = context;
        }

        // GET: Depositoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Deposito.ToListAsync());
        }

        // GET: Depositoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var deposito = await _context.Deposito
                .FirstOrDefaultAsync(m => m.Id == id);
            if (deposito == null)
            {
                return NotFound();
            }

            return View(deposito);
        }

        // GET: Depositoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Depositoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] Deposito deposito)
        {
            if (ModelState.IsValid)
            {
                _context.Add(deposito);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(deposito);
        }

        // GET: Depositoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var deposito = await _context.Deposito.FindAsync(id);
            if (deposito == null)
            {
                return NotFound();
            }
            return View(deposito);
        }

        // POST: Depositoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] Deposito deposito)
        {
            if (id != deposito.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(deposito);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DepositoExists(deposito.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(deposito);
        }

        // GET: Depositoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var deposito = await _context.Deposito
                .FirstOrDefaultAsync(m => m.Id == id);
            if (deposito == null)
            {
                return NotFound();
            }

            return View(deposito);
        }

        // POST: Depositoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var deposito = await _context.Deposito.FindAsync(id);
            _context.Deposito.Remove(deposito);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DepositoExists(int id)
        {
            return _context.Deposito.Any(e => e.Id == id);
        }

        public class DepartmentsController : Controller
        {
            public IActionResult Index()
            {
                List<Deposito> list = new List<Deposito>();
                list.Add(new Deposito { Id = 7, Name = "Eletronics" });
                list.Add(new Deposito { Id = 8, Name = "Fashion" });

                return View(list);
            }
        }
    }
}
