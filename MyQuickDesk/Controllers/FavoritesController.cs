using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyQuickDesk.ApplicationUser;
using MyQuickDesk.DatabaseContext;
using MyQuickDesk.Entities;

namespace MyQuickDesk.Controllers
{
    public class FavoritesController : Controller
    {
        private readonly MyQuickDeskContext _context;
        private readonly UserContext _userContext;

        public FavoritesController(MyQuickDeskContext context, UserContext userContext)
        {
            _context = context;
            _userContext = userContext;
        }

        // GET: Favorites
        public async Task<IActionResult> Index()
        {
            var id = _userContext.GetCurrentUser().Id;
            var favorites = _context.Favorites.FirstOrDefault(f => f.UserId == id);
            return View(favorites);
        }

        //// GET: Favorites/Details/5
        //public async Task<IActionResult> Details(Guid? id)
        //{
        //    if (id == null || _context.Favorites == null)
        //    {
        //        return NotFound();
        //    }

        //    var favorites = await _context.Favorites
        //        .FirstOrDefaultAsync(m => m.UserId == id);
        //    if (favorites == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(favorites);
        //}

        //// GET: Favorites/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Favorites/Create
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Id")] Favorites favorites)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        favorites.UserId = Guid.NewGuid();
        //        _context.Add(favorites);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(favorites);
        //}

        //// GET: Favorites/Edit/5
        //public async Task<IActionResult> Edit(Guid? id)
        //{
        //    if (id == null || _context.Favorites == null)
        //    {
        //        return NotFound();
        //    }

        //    var favorites = await _context.Favorites.FindAsync(id);
        //    if (favorites == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(favorites);
        //}

        //// POST: Favorites/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(Guid id, [Bind("Id")] Favorites favorites)
        //{
        //    if (id != favorites.UserId)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(favorites);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!FavoritesExists(favorites.UserId))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(favorites);
        //}

        //// GET: Favorites/Delete/5
        //public async Task<IActionResult> Delete(Guid? id)
        //{
        //    if (id == null || _context.Favorites == null)
        //    {
        //        return NotFound();
        //    }

        //    var favorites = await _context.Favorites
        //        .FirstOrDefaultAsync(m => m.UserId == id);
        //    if (favorites == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(favorites);
        //}

        //// POST: Favorites/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(Guid id)
        //{
        //    if (_context.Favorites == null)
        //    {
        //        return Problem("Entity set 'MyQuickDeskContext.Favorites'  is null.");
        //    }
        //    var favorites = await _context.Favorites.FindAsync(id);
        //    if (favorites != null)
        //    {
        //        _context.Favorites.Remove(favorites);
        //    }
            
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool FavoritesExists(Guid id)
        //{
        //  return (_context.Favorites?.Any(e => e.UserId == id)).GetValueOrDefault();
        //}
    }
}
