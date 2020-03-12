using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using MusicOrganizer.Models;

namespace MusicOrganizer.Controllers
{
    public class SearchesController : Controller
    {
        [HttpGet("/searches/new")]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/searches/{searchTerm}")]
        public ActionResult Show(string searchTerm)
        {
            int id = Artist.FindIdByName(searchTerm);
            if (id < 1)
            {
                return RedirectToAction("New");
            }
            Artist result = Artist.FindById(id);
            return View(result);
        }
    }
}