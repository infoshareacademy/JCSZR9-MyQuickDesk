using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyQuickDesk.DAL.Repository;
using MyQuickDesk.DAL.Entities;



namespace MyQuickDesk.Controllers
{

    public class DeskController : Controller
    {
        private readonly IDeskRepository _deskRepository;

        public DeskController(IDeskRepository deskRepository)
        {
            _deskRepository = deskRepository;

        }

        // GET: DeskController
        public ActionResult Index()
        {
            var model = _deskRepository.GetAll();
            return View(model);
        }

        // GET: DeskController/Details/5
        public ActionResult Details(Guid id)
        {
            var model = _deskRepository.GetById(id);
            return View(model);
        }

        // GET: DeskController/Create
        [Authorize(Roles = "Admin")]
        public ActionResult Create(Guid id)
        {
            var model = new Desk { Id = id };

            return View(model);
        }

        // POST: DeskController/Create
        [HttpPost]
        [Route("Desk/Create/{id?}")]
        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Desk model)
        {
            try
            {
                _deskRepository.Create(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DeskController/Edit/5
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(Guid id)
        {
            var model = _deskRepository.GetById(id);
            return View(model);
        }

        // POST: DeskController/Edit/5
        [HttpPost]
        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Guid id, Desk model)
        {
            try
            {
                _deskRepository.Update(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DeskController/Delete/5
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(Guid id)
        {
            var model = _deskRepository.GetById(id);
            return View(model);
        }

        // POST: DeskController/Delete/5
        [HttpPost]
        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Guid id, Desk model)
        {
            try
            {
                _deskRepository.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
