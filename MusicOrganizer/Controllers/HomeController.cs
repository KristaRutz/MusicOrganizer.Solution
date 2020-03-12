using Microsoft.AspNetCore.Mvc;
using MusicOrganizer.Models;

namespace MusicOrganizer.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index() { return View(); }
    }
}