using Microsoft.AspNetCore.Mvc;
using PremierProjet.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetTests.Controllers
{
    public class ControleurShould
    {
        [Fact] // Type de test
        public void IndexHomeShowText() // Méthode de test
        {
            var homeController = new HomeController();  //Créer le contrôleur
            var result = homeController.Index(1);       //Appeler la méthode d'action à tester
            var textResult = Assert.IsType<string>(result); //Vérifier le type du résultat
            var expected = "Bonjour 1";     //Déclarer le résultat attendu
            Assert.Equal(expected, result); //Vérifier le résultat obtenu
        }

        [Fact]
        public void HomePage2ShowView()
        {
            var homeController = new HomeController();
            var result = homeController.Page2();
            var textResult = Assert.IsType<ViewResult>(result);
        }
    }
}
