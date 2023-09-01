using System.Globalization;
using System.Resources;
using Microsoft.AspNet.Identity;
using Microsoft.Reporting.Map.WebForms.BingMaps;
using MyQuickDesk.DAL.Entities;
using MyQuickDesk.DAL.ApplicationUser;
using Microsoft.AspNet.Identity.EntityFramework;


namespace MyQuickDesk.DAL.Repository
{
    public class AdminRepository
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AdminRepository(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<AdminPanelModel> GetAdminPanelModelAsync()
        {
            var users = _userManager.Users.ToList();
            var roles = _roleManager.Roles.ToList();

            var userRoles = new Dictionary<string, List<string>>();

            foreach (var user in users)
            {
                var userRoleNames = await _userManager.GetRolesAsync(user);
                userRoles[user.Id] = userRoleNames.ToList();
            }

            var model = new AdminPanelModel
            {
                Users = users,
                Roles = roles,
                UserRoles = userRoles
            };

            return model;
        }

        public async Task<AdminPanelModel> GetAdminPanelModelForEditAsync(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return null;
            }

            var model = new AdminPanelModel
            {
                Users = _userManager.Users.ToList(),
                Roles = _roleManager.Roles.ToList(),
                User = user,
                SelectedRoles = (await _userManager.GetRolesAsync(user)).ToList()
            };

            return model;
        }

        public async Task<string> UpdateUserAndRolesAsync(string id, AdminPanelModel model, string cultureCode)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return GetTranslatedMessage("UserNotFound", cultureCode);
            
            }

            user.Email = model.User.Email;
            user.UserName = model.User.UserName;

            var result = await _userManager.UpdateAsync(user);
            if (!result.Succeeded)
            {
                return GetTranslatedMessage("AnError", cultureCode);
              
            }


            var userRoles = await _userManager.GetRolesAsync(user);
            await _userManager.RemoveFromRolesAsync(user, userRoles);

            foreach (var roleName in model.SelectedRoles)
            {
                await _userManager.AddToRoleAsync(user, roleName);
            }

            return null;
        }

        public async Task<IdentityUser> GetUserByIdAsync(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            return user;
        }

        public async Task<bool> DeleteUserAsync(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return false;
            }

            var result = await _userManager.DeleteAsync(user);
            return result.Succeeded;
        }

        public List<IdentityRole> GetRoles()
        {
            var roles = _roleManager.Roles.ToList();
            return roles;
        }

        public async Task<bool> CreateRoleAsync(string roleName)
        {
            if (!string.IsNullOrWhiteSpace(roleName))
            {
                var result = await _roleManager.CreateAsync(new IdentityRole(roleName));
                return result.Succeeded;
            }

            return false;
        }

        public async Task<IdentityRole> GetRoleByIdAsync(string id)
        {
            return await _roleManager.FindByIdAsync(id);
        }

        public async Task<bool> UpdateRoleAsync(string id, IdentityRole updatedRole)
        {
            var role = await _roleManager.FindByIdAsync(id);
            if (role == null)
            {
                return false;
            }

            role.Name = updatedRole.Name;
            var result = await _roleManager.UpdateAsync(role);

            return result.Succeeded;
        }

        public async Task<bool> DeleteRoleAsync(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);
            if (role == null)
            {
                return false;
            }

            var result = await _roleManager.DeleteAsync(role);

            return result.Succeeded;
        }
        public static string GetTranslatedMessage(string key, string cultureCode)
        {
            ResourceManager resourceManager = new ResourceManager(typeof(Resource));
            CultureInfo culture = CultureInfo.GetCultureInfo(cultureCode);
            string translatedMessage = resourceManager.GetString(key, culture);
            if (string.IsNullOrEmpty(translatedMessage))
            {
                CultureInfo defaultCulture = CultureInfo.GetCultureInfo("en-EN");
                translatedMessage = resourceManager.GetString(key, defaultCulture);
            }

            return translatedMessage;
        }
    }
}
