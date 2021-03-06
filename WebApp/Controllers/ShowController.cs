﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class ShowController : Controller
    {
        // GET: Show
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ShowSomething(int id)
        {
            return Content($"You send me to id {id}");
        }

        [HttpPost]
        public ActionResult PostForm(PostData item)
        {
            if (!ModelState.IsValid)
            {
                return Content("Entered is not valid");
            }
            using (var context = new MvcDbContext())
            {
                var existingUser = context.Users.FirstOrDefault(x => x.Login == item.Login);

                if (existingUser == null)
                {
                    context.Users.Add(item);
                    context.SaveChanges();
                }
                else
                {
                    return Content($"$User with login {item.Login} is already exist.");
                }
            }
            return Content($"Hello {item.FirstName} {item.LastName},Your Age: {item.Age} \nGender: {item.Gender}");
        }
    }
}