using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyQuickDesk.Models;
using MyQuickDesk.Services;
using System.Threading.Tasks;

namespace MyQuickDesk.Controllers
{
    public class AdminController : Controller
    {
        private readonly AdminService _adminService;

        public AdminController(AdminService adminService)
        {
            _adminService = adminService;
        }

        public async Task<IActionResult> Index()
        {
            var model = await _adminService.GetAdminPanelModelAsync();
            return View(model);
        }

        public async Task<IActionResult> Edit(string id)
        {
            var model = await _adminService.GetAdminPanelModelForEditAsync(id);
            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, AdminPanelModel model, string cultureCode)
        {
            var result = await _adminService.UpdateUserAndRolesAsync(id, model,cultureCode);
            if (result != null)
            {
                ModelState.AddModelError(string.Empty, result);
                return View(model);
            }

            return RedirectToAction("Index");
        }


        public async Task<IActionResult> Delete(string id)
        {
            var user = await _adminService.GetUserByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var result = await _adminService.DeleteUserAsync(id);
            if (!result)
            {
                return NotFound();
            }

            return RedirectToAction("Index");
        }

        public IActionResult Roles()
        {
            var roles = _adminService.GetRoles();
            return View(roles);
        }

        public IActionResult CreateRole()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateRole(string roleName)
        {
            var result = await _adminService.CreateRoleAsync(roleName);
            if (!result)
            {
                return View();
            }

            return RedirectToAction("Roles");
        }

        public async Task<IActionResult> EditRole(string id)
        {
            var model = await _adminService.GetRoleByIdAsync(id);
            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditRole(string id, IdentityRole role)
        {
            var result = await _adminService.UpdateRoleAsync(id, role);
            if (!result)
            {
                return NotFound();
            }

            return RedirectToAction("Roles");
        }

        public async Task<IActionResult> DeleteRole(string id)
        {
            var role = await _adminService.GetRoleByIdAsync(id);
            if (role == null)
            {
                return NotFound();
            }

            return View(role);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteRoleConfirmed(string id)
        {
            var result = await _adminService.DeleteRoleAsync(id);
            if (!result)
            {
                return NotFound();
            }

            return RedirectToAction("Roles");
        }

    }
}
