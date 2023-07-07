using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using MyQuickDesk.Filters;
using MyQuickDesk.Models;
using System.Diagnostics;
using System.Globalization;

namespace MyQuickDesk.Controllers
{
    [LanguageFilter]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var currentCulture = CultureInfo.CurrentCulture.Name;
            ViewBag.CurrentCulture = currentCulture;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult ChangeLanguage(string culture)
        {
            
            if (!HttpContext.Request.Path.StartsWithSegments("/Home"))
            {
                return RedirectToAction("ActionOnOtherPage");
            }
            Response.Cookies.Append(
            CookieRequestCultureProvider.DefaultCookieName,
            CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
            new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) });

            return RedirectToAction("Index", "Home");
        }

    }
}