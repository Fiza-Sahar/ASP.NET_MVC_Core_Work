using Microsoft.AspNetCore.Mvc;

namespace MyFirstMVCApp.Controllers
{
    public class AboutController : Controller
    {

        //[Route("/About")]
        public ActionResult About()
        {
            return View();
        }
    }
}
