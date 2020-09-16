using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EStudy.MVC.Models;
using EStudy.Application.Interfaces.MVC;
using EStudy.Application.ViewModels.User;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;

namespace EStudy.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IUserService userService;
        public HomeController(ILogger<HomeController> logger, IUserService _userService)
        {
            _logger = logger;
            userService = _userService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("login")]
        public IActionResult LoginUser()
        {
            return View();
        }

        [HttpPost("login")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LoginUser(AuthViewModel model)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Дані не валідні");
                return View(model);
            }
            var user = await userService.LoginUser(model);
            if (user.NotFoundByLogin)
            {
                ModelState.AddModelError("", "Користувача з таким email не знайдено");
                return View(model);
            }
            if (user.InvalidPassword)
            {
                ModelState.AddModelError("", "Логін або пароль не правильні");
                return View(model);
            }
            if (user.AccountNotVerified)
            {
                ModelState.AddModelError("", "Ваш аккаунт не підтвердженно");
                return View(model);
            }
            await Authenticate(user);
            return LocalRedirect("");
        }



        [NonAction]
        private async Task Authenticate(LoginViewModel model)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, model.Firstname+" "+model.Lastname),
                new Claim(ClaimTypes.Role, model.Role),
                new Claim(ClaimTypes.Email, model.Username),
                new Claim(ClaimTypes.NameIdentifier, model.Id.ToString()),
                new Claim("Photo", model.Photo),
                new Claim("Status", model.UserStatus)
            };
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return LocalRedirect("Login");
        }
    }
}
