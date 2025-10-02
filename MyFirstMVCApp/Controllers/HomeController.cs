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

            
            ViewData["Var1"] = "Message from view Data";
            ViewBag.Var2 = "Message from View Bag";
            TempData["Var3"] = "Message from TempData";
            return View();
        }

        public ActionResult About() { 
        
        return View();
        
        }

        
    }
}
