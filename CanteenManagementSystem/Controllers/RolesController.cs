using CanteenManagementSystem.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CanteenManagementSystem.Controllers
{
    public class RolesController : Controller
    {
        ApplicationDbContext _db = new ApplicationDbContext();
        // GET: Roles
        public ActionResult List()
        {
            var list = _db.Roles.ToList();
            return View(list);
        }

        public ActionResult Create()
        {
            var role = new IdentityRole();
            return View(role);
        }
        [HttpPost]
        public ActionResult Create(IdentityRole identityRole)
        {
            _db.Roles.Add(identityRole);
            _db.SaveChanges();
            return RedirectToAction("List");
        }
    }
}