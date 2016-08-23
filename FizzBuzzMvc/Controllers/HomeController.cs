using System.Web.Mvc;

namespace FizzBuzzMvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(int number = 20)
        {
            for (int i = 1; i <= number; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    ViewBag.Message += "FizzBuzz ";
                }
                else if (i % 3 == 0)
                {
                    ViewBag.Message += "Fizz ";
                }
                else if (i % 5 == 0)
                {
                    ViewBag.Message += "Buzz ";
                }
                else
                {
                    ViewBag.Message += $"{i} ";
                }
            }
            ViewBag.Message = ViewBag.Message?.Trim();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "This is a simple example of a TDD built fizz-buzz MVC app";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact me on twitter @lukejkwarren or via email luke@lukewarrendev.co.za";

            return View();
        }
    }
}