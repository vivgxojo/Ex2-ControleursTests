using Microsoft.AspNetCore.Mvc;

namespace PremierProjet.Controllers
{
    public class HomeController : Controller
    {
        public string Index(int id)
        {
            //var texte = "<h1>Bienvenu au cours " + id + " de ASP.NET MVC</h1>";
            return "Bonjour " + id;
            //return View();
        }

        public IActionResult Page2()
        {
            return View();
        }
    }
}
