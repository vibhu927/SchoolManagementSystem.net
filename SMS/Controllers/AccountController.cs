using Microsoft.AspNetCore.Mvc;

namespace SMS.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
