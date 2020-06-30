using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AcoStand.Data;
using AcoStand.Models;

namespace AcoStand.Controllers
{
    public class ArtigosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ArtigosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Artigos
        public async Task<IActionResult> Index()
        {
            //obter a lsita dos artigos
            var artigos = _context.Artigos.Include(a => a.Categoria).Include(a => a.Dono);
            
            

            return View(await artigos.ToListAsync());
        }

        // GET: Artigos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var artigos = await _context.Artigos
                .Include(a => a.Categoria)
                .Include(a => a.Dono)
                .FirstOrDefaultAsync(m => m.IdArtigo == id);
            if (artigos == null)
            {
                return NotFound();
            }

            return View(artigos);
        }

        // GET: Artigos/Create
        public IActionResult Create()
        {
            ViewData["CategoriaFK"] = new SelectList(_context.Categorias, "IdCategoria", "Designacao");
            ViewData["DonoFK"] = new SelectList(_context.Utilizadores, "IdUtilizador", "Localidade");
            return View();
        }

        // POST: Artigos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdArtigo,Titulo,Preco,Descricao,Contacto,Validado,DonoFK,CategoriaFK")] Artigos artigos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(artigos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoriaFK"] = new SelectList(_context.Categorias, "IdCategoria", "Designacao", artigos.CategoriaFK);
            ViewData["DonoFK"] = new SelectList(_context.Utilizadores, "IdUtilizador", "Localidade", artigos.DonoFK);
            return View(artigos);
        }

        // GET: Artigos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var artigos = await _context.Artigos.FindAsync(id);
            if (artigos == null)
            {
                return NotFound();
            }
            ViewData["CategoriaFK"] = new SelectList(_context.Categorias, "IdCategoria", "Designacao", artigos.CategoriaFK);
            ViewData["DonoFK"] = new SelectList(_context.Utilizadores, "IdUtilizador", "Localidade", artigos.DonoFK);
            return View(artigos);
        }

        // POST: Artigos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdArtigo,Titulo,Preco,Descricao,Contacto,Validado,DonoFK,CategoriaFK")] Artigos artigos)
        {
            if (id != artigos.IdArtigo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(artigos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArtigosExists(artigos.IdArtigo))
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
            ViewData["CategoriaFK"] = new SelectList(_context.Categorias, "IdCategoria", "Designacao", artigos.CategoriaFK);
            ViewData["DonoFK"] = new SelectList(_context.Utilizadores, "IdUtilizador", "Localidade", artigos.DonoFK);
            return View(artigos);
        }

        // GET: Artigos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var artigos = await _context.Artigos
                .Include(a => a.Categoria)
                .Include(a => a.Dono)
                .FirstOrDefaultAsync(m => m.IdArtigo == id);
            if (artigos == null)
            {
                return NotFound();
            }

            return View(artigos);
        }

        // POST: Artigos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var artigos = await _context.Artigos.FindAsync(id);
            _context.Artigos.Remove(artigos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ArtigosExists(int id)
        {
            return _context.Artigos.Any(e => e.IdArtigo == id);
        }
    }
}
