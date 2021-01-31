using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UsersApp.Data;
using UsersApp.Models;

namespace UsersApp.Controllers
{
    public class ClientController : Controller
    {
        private readonly UsersAppContext _context;

        public ClientController(UsersAppContext context)
        {
            _context = context;
        }
        // GET: Client
        public ActionResult Index()
        {
            TempData["idrol"] = 0;
            var data= _context.Clients.ToList();
           
            return View(data);
        }

       

        // GET: Client/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Client/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Client   cliobj)
        {
            try
            {
                _context.Clients.Add(cliobj);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Client/Edit/5
        public ActionResult Edit(int id, int idrol)
        {
            TempData["idrol"] = idrol;
            var cli = _context.Clients.FirstOrDefault(c => c.IdClient == id);
            return View(cli);
        }

        // POST: Client/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Client  client)
        {
            try
            {
               
                _context.Clients.Update(client);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Client/Delete/5
        public ActionResult Delete(int id, int idrol)
        {
            TempData["idrol"] = idrol;
            var cli= _context.Clients.FirstOrDefault(c => c.IdClient == id);
            return View(cli);
        }

        // POST: Client/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Client   cli)
        {
            try
            {

                _context.Clients.Remove(cli);
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