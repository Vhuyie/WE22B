using Microsoft.AspNetCore.Mvc;

namespace AfribaseAuction.Controllers
{
    public class ForgotPasswordController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
