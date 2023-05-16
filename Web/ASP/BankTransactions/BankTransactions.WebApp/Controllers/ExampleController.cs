using BankTransactions.Models;
using Microsoft.AspNetCore.Mvc;

namespace BankTransactions.WebApp.Controllers
{
    public class ExampleController : Controller
    {
        public IActionResult Index()
        {
            return View(new object());
        }

        public IActionResult NamedView()
        {
            return View("MySuperView");
        }

        public IActionResult DataView()
        {
            ViewData["chaine1"] = "Voici une super chaine de caractères !";

            ViewBag.chaine1 = "Voilà une autre chaîne, avec un chapeau !";

            return View();
        }

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

            return View(transaction);
        }
    }
}
