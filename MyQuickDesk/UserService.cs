using System.Security.Claims;

namespace MyQuickDesk.DAL.ApplicationUser
{
    public interface IUserContext
    {
        CurrentUser GetCurrentUser();
        bool IsUserLoggedIn();
    }
  
    public class UserContext : IUserContext
    {
        private IHttpContextAccessor _httpContextAccessor;

        public UserContext(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;

        }
        //SERWIS
        public CurrentUser GetCurrentUser()
        {
            var user = _httpContextAccessor?.HttpContext?.User;
            if (user == null
                || user.FindFirst(c=>c.Type ==ClaimTypes.NameIdentifier)==null
                || user.FindFirst(c=>c.Type == ClaimTypes.Email) == null)
            {
                throw new InvalidOperationException("User context is not present!");
            }

            var id = Guid.Parse(user.FindFirst(c => c.Type == ClaimTypes.NameIdentifier)!.Value);
            var email = user.FindFirst(c => c.Type == ClaimTypes.Email)!.Value;
            var roles = user.Claims.Where(c => c.Type == ClaimTypes.Role).Select(c => c.Value);

            return new CurrentUser(id, email, roles);
        }
        public bool IsUserLoggedIn()
        {
            var user = _httpContextAccessor?.HttpContext?.User;
            return user != null && user.Identity.IsAuthenticated;
        }

    }

}
