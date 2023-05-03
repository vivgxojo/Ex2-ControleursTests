using Microsoft.AspNetCore.Mvc;

namespace PremierProjet.Controllers
{
    public class WelcomeController : Controller
    {
        public IActionResult WelcomeDefault()
        {
            return Content("Bienvenue dans ma nouvelle application! ");
        }

        public IActionResult WelcomeName(string nom, string prenom)
        {
            //return Content("Salut " + prenom + " " + nom + " ! Bienvenue dans ma nouvelle application!");
            if(nom == null || prenom == null)
            {
                return View("Erreur");
            }

            ViewData["nom"] = nom;
            ViewData["prenom"] = prenom;

            return View("Welcome");
        }
    }
}
