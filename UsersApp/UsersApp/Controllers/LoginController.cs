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
    public class LoginController : Controller
    {
        private readonly UsersAppContext _context;

        public LoginController(UsersAppContext context)
        {
            _context = context;
        }
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(LoginModel login)
        {
            try
            {
                var user = _context.Users.FirstOrDefault(x => x.UuserName == login.Username && x.Password == login.Password);
                if (user==null)
                {
                    
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                  
                    if (user.TypeUser==0)
                    {
                        TempData["iduser"]=user.IdUser;
                        ViewBag.IdUser = user.IdUser;
                        ViewBag.Rol = 0;
                    return RedirectToAction("Index", "Client");
                    }
                    else
                    {
                        TempData["iduser"] = user.IdUser;
                        ViewBag.IdUser = user.IdUser;
                        ViewBag.Rol = 1;
                        return RedirectToAction("Index", "User");

                    }
                   
                }
                
                
            }
            catch
            {
                return View();
            }
        }

        // GET: Login/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Login/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Login/Create
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

        // GET: Login/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Login/Edit/5
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

        // GET: Login/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Login/Delete/5
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