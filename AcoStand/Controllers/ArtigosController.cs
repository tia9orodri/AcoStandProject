using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AcoStand.Data;
using AcoStand.Models;
using X.PagedList;
using Microsoft.AspNetCore.Authorization;

namespace AcoStand.Controllers {

    [Authorize(Roles = "User, Admin")]
    public class ArtigosController : Controller {

        private readonly ApplicationDbContext _db;

        public ArtigosController(ApplicationDbContext context) {
            _db = context;
        }

        // GET: Artigos
        public async Task<IActionResult> Index(int? pagina) {
            //Define o numero de itens por cada página
            const int itensPorPagina = 5;
            //se nao informado nº da página vai para a 1
            int numeroPagina = (pagina ?? 1);

            //obter a lsita dos artigos
            var artigos = _db.Artigos.Include(a => a.Categoria).Include(a => a.Dono);

            //verifica role do user, se não for gestor só mostra os validados
            if (!User.IsInRole("Gestores")) {
               // artigos = _db.Artigos.Include(a => a.Categoria).Include(a => a.Dono).Where(a => a.Validado == true);
            }

            return View(await artigos.ToPagedListAsync(numeroPagina, itensPorPagina));
        }

        // GET: Artigos/Details/5
        public async Task<IActionResult> Details(int? id) {
            if (id == null) {
                return NotFound();
            }

            var artigos = await _db.Artigos
                .Include(a => a.Categoria)
                .Include(a => a.Dono)
                .FirstOrDefaultAsync(m => m.IdArtigo == id);
            if (artigos == null) {
                return NotFound();
            }

            return View(artigos);
        }

        // GET: Artigos/Create
        public IActionResult Create() {
            ViewData["CategoriaFK"] = new SelectList(_db.Categorias, "IdCategoria", "Designacao");
            ViewData["DonoFK"] = new SelectList(_db.Utilizadores, "IdUtilizador", "Localidade");
            return View();
        }

        // POST: Artigos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdArtigo,Titulo,Preco,Descricao,Contacto,Validado,DonoFK,CategoriaFK")] Artigos artigos) {
            if (ModelState.IsValid) {
                _db.Add(artigos);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoriaFK"] = new SelectList(_db.Categorias, "IdCategoria", "Designacao", artigos.CategoriaFK);
            ViewData["DonoFK"] = new SelectList(_db.Utilizadores, "IdUtilizador", "Localidade", artigos.DonoFK);
            return View(artigos);
        }

        // GET: Artigos/Edit/5
        public async Task<IActionResult> Edit(int? id) {
            if (id == null) {
                return NotFound();
            }

            var artigos = await _db.Artigos.FindAsync(id);
            if (artigos == null) {
                return NotFound();
            }
            ViewData["CategoriaFK"] = new SelectList(_db.Categorias, "IdCategoria", "Designacao", artigos.CategoriaFK);
            ViewData["DonoFK"] = new SelectList(_db.Utilizadores, "IdUtilizador", "Localidade", artigos.DonoFK);
            return View(artigos);
        }

        // POST: Artigos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdArtigo,Titulo,Preco,Descricao,Contacto,Validado,DonoFK,CategoriaFK")] Artigos artigos) {
            if (id != artigos.IdArtigo) {
                return NotFound();
            }

            if (ModelState.IsValid) {
                try {
                    _db.Update(artigos);
                    await _db.SaveChangesAsync();
                } catch (DbUpdateConcurrencyException) {
                    if (!ArtigosExists(artigos.IdArtigo)) {
                        return NotFound();
                    } else {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoriaFK"] = new SelectList(_db.Categorias, "IdCategoria", "Designacao", artigos.CategoriaFK);
            ViewData["DonoFK"] = new SelectList(_db.Utilizadores, "IdUtilizador", "Localidade", artigos.DonoFK);
            return View(artigos);
        }

        // GET: Artigos/Delete/5
        public async Task<IActionResult> Delete(int? id) {
            if (id == null) {
                return NotFound();
            }

            var artigos = await _db.Artigos
                .Include(a => a.Categoria)
                .Include(a => a.Dono)
                .FirstOrDefaultAsync(m => m.IdArtigo == id);
            if (artigos == null) {
                return NotFound();
            }

            return View(artigos);
        }

        // POST: Artigos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id) {
            var artigos = await _db.Artigos.FindAsync(id);
            _db.Artigos.Remove(artigos);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ArtigosExists(int id) {
            return _db.Artigos.Any(e => e.IdArtigo == id);
        }
    }
}
