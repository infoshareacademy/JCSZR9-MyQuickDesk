using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQuickDesk.DAL.Repository
{
    public interface IUserRepository
    {
        CurrentUser GetCurrentUser();
        bool IsCurrentUserAdmin();
    }
    internal class UserRepository:IUserRepository
    {
        private IHttpContextAccessor _httpContextAccessor;

        public UserContext(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;

        }


        public bool IsCurrentUserAdmin()
        {
            var currentUser = _userContext.GetCurrentUser();
            if (currentUser == null || !currentUser.IsAdmin("Admin"))
            {
                return;
            }
        }
    }
}
