using Microsoft.AspNetCore.Mvc;
using MusicOrganizer.Models;
using System.Collections.Generic;

namespace MusicOrganizer.Controllers
{
    public class RecordsController : Controller
    {
        [HttpGet("/records")]
        public ActionResult Index() { return View(); }

        [HttpGet("/records/new")]
        public ActionResult New() { return View(); }

        [HttpPost("/records")]
        public ActionResult Create()
        {
            Record myRecord = new Record("White Album");
            return RedirectToAction("Index");
        }

        [HttpGet("/records/{id}")]
        public ActionResult Show(int id)
        {
            Record foundRecord = Record.Find(id);
            return View(foundRecord);
        }

    }
}