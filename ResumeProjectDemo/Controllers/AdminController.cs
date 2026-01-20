using Microsoft.AspNetCore.Mvc;

namespace ResumeProjectDemo.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
