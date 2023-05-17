using BankTransactions.Models;
using Microsoft.AspNetCore.Mvc;

namespace BankTransactions.WebApp.Controllers
{
    public class ExampleController : Controller
    {
        /// <summary>
        /// GET /example/index 
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View(); // Retourne la vue "Index" (nom de la méthode)
        }

        /// <summary>
        /// GET /example/namedview/
        /// </summary>
        /// <returns></returns>
        public IActionResult NamedView()
        {
            return View("MySuperView"); // retourne la vue "MySuperView"
        }

        /// <summary>
        /// GET /example/dataview/
        /// Gestion de ViewData et ViewBag : https://www.tektutorialshub.com/asp-net-core/asp-net-core-viewbag-viewdata/
        /// </summary>
        /// <returns></returns>
        public IActionResult DataView()
        {
            ViewData["chaine1"] = "Voici une super chaine de caractères !";

            ViewBag.chaine1 = "Voilà une autre chaîne, avec un chapeau !";

            return View();
        }

        /// <summary>
        /// GET /example/modelview/
        /// </summary>
        /// <returns></returns>
        public IActionResult ModelView()
        {
            BankTransaction transaction = new()
            {
                Transaction_Id = 22,
                Transaction_Date = DateTime.Now,
                Transaction_From = 23121456987,
                Transaction_To = 10236547898,
                Transaction_Amount = (decimal) 1000.45
            };

            return View(transaction); // transmet l'objet en tant que "modèle". 
        }
    }
}
