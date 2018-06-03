using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SistemaPsicologia.Models;

namespace SistemaPsicologia.Controllers
{
    public class RegistrarPsicologoController : Controller
    {
        private readonly SistemaPsicologiaContext _context;

        public RegistrarPsicologoController(SistemaPsicologiaContext context)
        {
            _context = context;
        }

        // GET: RegistrarPsicologo
        public async Task<IActionResult> Index()
        {
            return View(await _context.RegistrarPsicologo.ToListAsync());
        }

        // GET: RegistrarPsicologo/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registrarPsicologo = await _context.RegistrarPsicologo
                .SingleOrDefaultAsync(m => m.Id == id);
            if (registrarPsicologo == null)
            {
                return NotFound();
            }

            return View(registrarPsicologo);
        }

        // GET: RegistrarPsicologo/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RegistrarPsicologo/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Matricula,Nombres,Apellidos,Semestre,Telefono")] RegistrarPsicologo registrarPsicologo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(registrarPsicologo);
                await _context.SaveChangesAsync();
                
                return RedirectToAction(nameof(Index));
            }
            return View(registrarPsicologo);
        }


        // GET: RegistrarPsicologo/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registrarPsicologo = await _context.RegistrarPsicologo.SingleOrDefaultAsync(m => m.Id == id);
            if (registrarPsicologo == null)
            {
                return NotFound();
            }
            return View(registrarPsicologo);
        }

        // POST: RegistrarPsicologo/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Matricula,Nombres,Apellidos,Semestre,Telefono")] RegistrarPsicologo registrarPsicologo)
        {
            if (id != registrarPsicologo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(registrarPsicologo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RegistrarPsicologoExists(registrarPsicologo.Id))
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
            return View(registrarPsicologo);
        }

        // GET: RegistrarPsicologo/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registrarPsicologo = await _context.RegistrarPsicologo
                .SingleOrDefaultAsync(m => m.Id == id);
            if (registrarPsicologo == null)
            {
                return NotFound();
            }

            return View(registrarPsicologo);
        }

        // POST: RegistrarPsicologo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var registrarPsicologo = await _context.RegistrarPsicologo.SingleOrDefaultAsync(m => m.Id == id);
            _context.RegistrarPsicologo.Remove(registrarPsicologo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RegistrarPsicologoExists(int id)
        {
            return _context.RegistrarPsicologo.Any(e => e.Id == id);
        }
    }
}
