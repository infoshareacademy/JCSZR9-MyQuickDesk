using System.Security.Claims;

namespace MyQuickDesk.ApplicationUser
{
    public interface IUserContext
    {
        CurrentUser GetCurrentUser();
    }

    public class UserContext : IUserContext
    {
        private IHttpContextAccessor _httpContextAccessor;

        public UserContext(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;

        }

        public CurrentUser GetCurrentUser()
        {
            var user = _httpContextAccessor?.HttpContext?.User;
            if (user == null)
            {
                throw new InvalidOperationException("IdentityUser context is not present!");
            }

            var id = Guid.Parse(user.FindFirst(c => c.Type == ClaimTypes.NameIdentifier)!.Value);
            var email = user.FindFirst(c => c.Type == ClaimTypes.Email)!.Value;
            var roles = user.Claims.Where(c => c.Type == ClaimTypes.Role).Select(c => c.Value);

            return new CurrentUser(id, email, roles);
        }


    }
}
