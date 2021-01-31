using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UsersApp.Data;
using UsersApp.Models;

namespace UsersApp.Controllers
{
    public class AgendaController : Controller
    {
        private readonly UsersAppContext _context;
        public AgendaController(UsersAppContext context)
        {
            _context = context;

        }
        // GET: Agenda
        public ActionResult Index()
        {
            return View();
        }

        // GET: Agenda/Details/5
        public ActionResult Details(int id)
        {
            ViewBag.idUser = id;
            return View();
        }


        public JsonResult GetAgendas(int id)
        {
            var user = _context.Users.FirstOrDefault(u => u.IdUser == id);
            var data = _context.Agendas.Where(a => a.IdUser == id).ToList().Select(d => new AgendaModel { Date = d.Date.ToString("dd-MM-yyyy"), IdAgenda = d.IdAgenda, IdUser = d.IdUser, State = d.State });


            return Json(new { items = data, user = user });
        }

        // GET: Agenda/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Agenda/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Agenda/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Agenda/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Agenda/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Agenda/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}