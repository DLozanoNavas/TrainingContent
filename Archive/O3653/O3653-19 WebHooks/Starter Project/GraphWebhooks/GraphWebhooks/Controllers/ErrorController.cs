﻿using System.Web.Mvc;


namespace GraphWebhooks.Controllers
{
    public class ErrorController : Controller
    {
        public ViewResult Index()
        {
            if (Request["message"] != null)
            {
                TempData["message"] = Request["message"];
            }
            return View("Error");
        }
       
    }
}