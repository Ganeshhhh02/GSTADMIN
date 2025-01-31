using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFCodeFirst.Context;
using EFCodeFirst.Models;

namespace EFCodeFirst.Controllers
{
    public class DefaultController : Controller
    {
        AdminContext context = new AdminContext();
        // GET: Default
        public ActionResult Index()
        {
            var UserList = context.tblUser.ToList();

            return View(UserList);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(User objU)
        {
            context.tblUser.Add(objU);
            context.SaveChanges();
            return RedirectToAction("Index");

        }

        public ActionResult Details(int Id)
        {
            var UserDetails = context.tblUser.Find(Id);

            return View(UserDetails);


        }

        [HttpGet]
        public ActionResult Edit(int Id)
        {
            var EditUserDetails = context.tblUser.Find(Id);

            return View(EditUserDetails);

            
        }

        [HttpPost]
        public ActionResult Edit(User objU)
        {
            context.tblUser.AddOrUpdate(objU);
            context.SaveChanges();
            return RedirectToAction("Index");
            
        }

        
        [HttpGet]
        public ActionResult Delete(int Id) 

        {
            var User = context.tblUser.Find(Id);
            context.tblUser.Remove( User);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}