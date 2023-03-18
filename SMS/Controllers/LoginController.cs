using Microsoft.AspNetCore.Mvc;

namespace SMS.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
