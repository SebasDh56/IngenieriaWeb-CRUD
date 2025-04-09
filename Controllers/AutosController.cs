using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using IngenieriaWeb1.Models;

namespace IngenieriaWeb1.Controllers
{
    public class AutosController : Controller
    {
        private readonly AutosContext _context;

        public AutosController(AutosContext context)
        {
            _context = context;
        }

        // GET: Autos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Autos.ToListAsync());
        }

        // GET: Autos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var autos = await _context.Autos
                .FirstOrDefaultAsync(m => m.AutoId == id);
            if (autos == null)
            {
                return NotFound();
            }

            return View(autos);
        }

        // GET: Autos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Autos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AutoId,Placa,Marca,Modelo,Propietario,Año")] Autos autos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(autos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(autos);
        }

        // GET: Autos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var autos = await _context.Autos.FindAsync(id);
            if (autos == null)
            {
                return NotFound();
            }
            return View(autos);
        }

        // POST: Autos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AutoId,Placa,Marca,Modelo,Propietario,Año")] Autos autos)
        {
            if (id != autos.AutoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(autos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AutosExists(autos.AutoId))
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
            return View(autos);
        }

        // GET: Autos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var autos = await _context.Autos
                .FirstOrDefaultAsync(m => m.AutoId == id);
            if (autos == null)
            {
                return NotFound();
            }

            return View(autos);
        }

        // POST: Autos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var autos = await _context.Autos.FindAsync(id);
            if (autos != null)
            {
                _context.Autos.Remove(autos);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AutosExists(int id)
        {
            return _context.Autos.Any(e => e.AutoId == id);
        }
    }
}
