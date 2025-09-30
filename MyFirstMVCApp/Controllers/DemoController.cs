
using Microsoft.AspNetCore.Mvc;

namespace MyFirstMVCApp.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ViewResult Show(int id)
        {
            if (id == 1)
                return View("Show1");
            else
                return View("Show2");
        }
    }
}


