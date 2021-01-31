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
            TempData["idrol"] = 1;
            var data = _context.Users.ToList();
            return View(data);
        }

        // GET: User/Details/5
        public ActionResult Details(int iduser)
        {
            TempData["idrol"] = 1;
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
            TempData["idrol"] = 1;
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
            TempData["idrol"] = 1;
            var user = _context.Users.FirstOrDefault(x => x.IdUser == id);
            return View(user);
        }

        // POST: User/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, User user)
        {
            try
            {
                _context.Users.Update(user);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

       
    }
}