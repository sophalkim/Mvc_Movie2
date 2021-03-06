﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie2.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index()
        {
            return View();
        }

        // GET: HelloWorld/Welcome
        public string Welcome(string name, int ID = 1)
        {
            return HttpUtility.HtmlEncode("Hello " + name + ", ID: " + ID);
        }

        // GET: HelloWorld/WriteName
        public string WriteName(string last, string first = "User")
        {
            return HttpUtility.HtmlEncode("Hi " + first + " " + last + ".");
        }

        // GET: HelloWorld/LoopMessage
        public ActionResult LoopMessage(string message = "Type a Message", int amount = 1)
        {
            ViewBag.message = message;
            ViewBag.amount = amount;
            return View();
        }
    }
}