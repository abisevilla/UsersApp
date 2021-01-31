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
    public class UserController : Controller
    {
        private readonly UsersAppContext _context;

        public UserController(UsersAppContext context)
        {
            _context = context;
        }
        // GET: User
        public ActionResult Index()
        {

            var data = _context.Users.ToList();
            return View(data);
        }

        // GET: User/Details/5
        public ActionResult Details(int iduser)
        {
         
            ViewBag.idUser = iduser;
            return View();
        }

        public JsonResult GetAgendas(int id)
        {
            var user = _context.Users.FirstOrDefault(u => u.IdUser == id);
            var data = _context.Agendas.Where(a => a.IdUser == id).ToList().Select(  d => new AgendaModel { Date= d.Date.ToString("dd-MM-yyyy"), IdAgenda=d.IdAgenda , IdUser=d.IdUser, State=d.State });

            
            return Json(new { items=data, user=user });
        }

        // GET: User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(User  user)
        {
            try
            {
                _context.Users.Add(user);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: User/Edit/5
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

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: User/Delete/5
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