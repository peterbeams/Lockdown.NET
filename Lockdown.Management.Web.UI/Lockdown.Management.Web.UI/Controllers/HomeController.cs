﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lockdown.Management.Web.UI.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Roles()
        {
            return View();
        }

        public ActionResult Tasks()
        {
            return View();
        }

        public ActionResult TasksInRoles()
        {
            return View();
        }
    }
}
