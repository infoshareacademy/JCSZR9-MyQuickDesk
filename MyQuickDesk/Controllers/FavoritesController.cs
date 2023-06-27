using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyQuickDesk.DatabaseContext;
using MyQuickDesk.Entities;

namespace MyQuickDesk.Controllers
{
    public class FavoritesController : Controller
    {
        private readonly MyQuickDeskContext _context;

        public FavoritesController(MyQuickDeskContext context)
        {
            _context = context;
        }
        public ActionResult AddToFavorites(int favoritesId)
        {
            // Pobranie produktu z bazy danych
            var favorites = _context.ParkingSpots.Find(favoritesId);

            // Utworzenie nowego elementu koszyka
            var favoriteItem = new Favorites
            {
                Id=favoritesId,
            };

            // Dodanie elementu koszyka do bazy danych
            _context.Favorites.Add(favoriteItem);
            _context.SaveChanges();

            return RedirectToAction("Favorites");
        }

        public ActionResult Favorites()
        {
            // Pobranie wszystkich elementów koszyka z bazy danych
            var favoriteItems = _context.Favorites.Include("ParkingSpot").ToList();

            return View(favoriteItems);
        }
    }
}
