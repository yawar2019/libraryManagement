using Microsoft.AspNetCore.Mvc;

namespace libraryManagement.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


    }
}
