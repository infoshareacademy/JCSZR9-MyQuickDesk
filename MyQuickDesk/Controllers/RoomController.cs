<<<<<<< HEAD
﻿//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//namespace MyQuickDesk.Controllers
//{
//    public class RoomController : Controller
//    {

//        private readonly RoomController 
//        // GET: RoomController
//        public ActionResult Index()
//        {
//            return View();
//        }

//        // GET: RoomController/Details/5
//        public ActionResult Details(int id)
//        {
//            return View();
//        }
=======
﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyQuickDesk.Services;
using MyQuickDesk.Models;

namespace MyQuickDesk.Controllers
{
    public class RoomController : Controller
    {
        private readonly RoomService _roomService;
        
        public RoomController()
        {
            _roomService = new RoomService();
        }
        // GET: RoomController
        public ActionResult Index()
        {
            var model = _roomService.GetAll();
            return View(model);
        }

        // GET: RoomController/Details/5
        public ActionResult Details(int id)
        {

            var model = _roomService.GetById(id);
            return View(model);
        }
>>>>>>> 75c8bc1e52a2945635f106f0c2659200fd9fd66f

//        // GET: RoomController/Create
//        public ActionResult Create()
//        {
//            return View();
//        }

<<<<<<< HEAD
//        // POST: RoomController/Create
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Create(IFormCollection collection)
//        {
//            try
//            {
//                return RedirectToAction(nameof(Index));
//            }
//            catch
//            {
//                return View();
//            }
//        }

//        // GET: RoomController/Edit/5
//        public ActionResult Edit(int id)
//        {
//            return View();
//        }

//        // POST: RoomController/Edit/5
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Edit(int id, IFormCollection collection)
//        {
//            try
//            {
//                return RedirectToAction(nameof(Index));
//            }
//            catch
//            {
//                return View();
//            }
//        }

//        // GET: RoomController/Delete/5
//        public ActionResult Delete(int id)
//        {
//            return View();
//        }

//        // POST: RoomController/Delete/5
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Delete(int id, IFormCollection collection)
//        {
//            try
//            {
//                return RedirectToAction(nameof(Index));
//            }
//            catch
//            {
//                return View();
//            }
//        }
//    }
//}
=======
        // POST: RoomController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create( Room model )
        {
            try
            {
                _roomService.Create(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RoomController/Edit/5
        public ActionResult Edit(int id)
        {
            var model = _roomService.GetById(id);
            return View(model);
        }

        // POST: RoomController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Room model)
        {
            try
            {
                _roomService.Update(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RoomController/Delete/5
        public ActionResult Delete(int id)
        {
            var model = _roomService.GetById(id);
            return View(model);
        }

        // POST: RoomController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Room model)
        {
            try
            {
                 _roomService.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
>>>>>>> 75c8bc1e52a2945635f106f0c2659200fd9fd66f
