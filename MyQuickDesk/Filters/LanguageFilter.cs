using Microsoft.AspNetCore.Mvc.Filters;
using System.Globalization;
using System.Threading;
using Microsoft.AspNetCore.Http;



namespace MyQuickDesk.Filters
{
    public class LanguageFilter: ActionFilterAttribute
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            // Odczytaj preferowany język użytkownika
            var preferredLanguage = context.HttpContext.Request.Headers["Accept-Language"].ToString();

            // Ustaw bieżący język w sesji lub pliku cookie
            context.HttpContext.Session.SetString("CurrentLanguage", preferredLanguage);
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            // Nic nie robimy po zakończeniu akcji
        }
    }
}
