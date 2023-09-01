using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using MyQuickDesk.DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using MyQuickDesk.DAL.Repository;
using MyQuickDesk.DAL.ApplicationUser;
using MyQuickDesk.Models;


namespace MyQuickDesk.Controllers
{
    public class AdminController : Controller
    {
        private readonly AdminRepository _adminRepository;

        public AdminController(AdminRepository adminRepository)
        {
            _adminRepository = adminRepository;
        }

        public async Task<IActionResult> Index()
        {
            var model = await _adminRepository.GetAdminPanelModelAsync();
            return View(model);
        }

        public async Task<IActionResult> Edit(string id)
        {
            var model = await _adminRepository.GetAdminPanelModelForEditAsync(id);
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
            var result = await _adminRepository.UpdateUserAndRolesAsync(id, model,cultureCode);
            if (result != null)
            {
                ModelState.AddModelError(string.Empty, result);
                return View(model);
            }

            return RedirectToAction("Index");
        }


        public async Task<IActionResult> Delete(string id)
        {
            var user = await _adminRepository.GetUserByIdAsync(id);
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
            var result = await _adminRepository.DeleteUserAsync(id);
            if (!result)
            {
                return NotFound();
            }

            return RedirectToAction("Index");
        }

        public IActionResult Roles()
        {
            var roles = _adminRepository.GetRoles();
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
            var result = await _adminRepository.CreateRoleAsync(roleName);
            if (!result)
            {
                return View();
            }

            return RedirectToAction("Roles");
        }

        public async Task<IActionResult> EditRole(string id)
        {
            var model = await _adminRepository.GetRoleByIdAsync(id);
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
            var result = await _adminRepository.UpdateRoleAsync(id, role);
            if (!result)
            {
                return NotFound();
            }

            return RedirectToAction("Roles");
        }

        public async Task<IActionResult> DeleteRole(string id)
        {
            var role = await _adminRepository.GetRoleByIdAsync(id);
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
            var result = await _adminRepository.DeleteRoleAsync(id);
            if (!result)
            {
                return NotFound();
            }

            return RedirectToAction("Roles");
        }

    }
}
