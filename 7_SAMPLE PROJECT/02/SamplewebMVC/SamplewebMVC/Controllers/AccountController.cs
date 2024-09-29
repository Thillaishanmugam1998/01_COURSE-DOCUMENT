using Microsoft.AspNetCore.Mvc;
using System.Security.Principal;

namespace SamplewebMVC.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult ForgotPassword()
        {
            return View();
        }
    }
}
