﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Desafio05.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

           public ActionResult Contato()
        {
            ViewBag.Message = "Contato";

            return View();
        }
    }
}