﻿using System.Web.Mvc;
using RootPosition.Services;

namespace Root.RootPosition.Controllers
{
    public class GalleryController : Controller
    {

        public ActionResult Index()
        {
            ViewBag.Title = "Gallery";
            var model = GalleryServiceController.GetGalleries("~/PhotoGallery");
            return View(model);
        }
    }
}
