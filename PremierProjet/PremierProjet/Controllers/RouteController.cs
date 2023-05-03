using Microsoft.AspNetCore.Mvc;

namespace PremierProjet.Controllers
{
    public class RouteController : Controller
    {
        public IActionResult Route1()
        {
            return Content("Route 1");
        }
    }
}
