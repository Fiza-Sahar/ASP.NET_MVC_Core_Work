using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyFirstMVCApp.Models;

namespace MyFirstMVCApp.Controllers
{
    public class HomeController : Controller
    {
        //[Route("")]
       public ActionResult index()
        {
            return View();
        }

        
    }
}
