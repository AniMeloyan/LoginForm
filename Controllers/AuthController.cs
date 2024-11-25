using LoginForm.Models;
using Microsoft.AspNetCore.Mvc;

namespace LoginForm.Controllers
{
    public class AuthController : Controller
    {
        public AuthController() {
            ViewData["Valod"] = "Hajox";
        }
        public IActionResult Index()
        {
           return RedirectToAction(nameof(Login1));
        }

        [HttpGet]
        public IActionResult Login1()
        {
            return View("Login");
        }
        [HttpPost]
        public IActionResult Login (Login field)
        {
            var users = new[]
            {
                new { Email = "ani.meloyan@mail.ru", Password = "pass123" },
                new { Email = "user@example.com", Password = "password123" }
            };

            var user = users.FirstOrDefault(u => u.Email == field.Email && u.Password == field.Password);
            if (user != null)
       
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.ErrorMessage = "Invalid email or password.";

            }

            return View();
        }
    }
}
