using AgroAppWeb.Middleware;
using BusinessLayer;
using EntityLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AgroAppWeb.Controllers
{
    public class AuthenticationController : Controller
    {
        public IActionResult LogIn()
        {
            return View();
        }
        public IActionResult Validate(string email, string pass)
        {
            Administrator a = AdministratorBL.Instance.validateUser(email, pass);
            if (a != null)
            {
                HttpContext.Session.SetObject("UserSession", a);
                return RedirectToAction("Home", "Private");
            }
            return RedirectToAction("LogIn");
        }
        public IActionResult LogOut()
        {
            HttpContext.Session.Remove("UserSession");
            return RedirectToAction("LogIn");
        }

    }
}