﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HuesenClicker.Controllers
{
    public class StartController : Controller
    {
        // GET: Start
        public ActionResult Start()
        {
            return View();
        }

        public ActionResult Einstellungen()
        {
            return View();
        }

        public ActionResult OnclickStart()
        {
            return Einstellungen();
        }

        public ActionResult Spiel()
        {
            return View();
        }
    }
}