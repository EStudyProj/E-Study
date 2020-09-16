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
        public async Task<IActionResult> LoginUser(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Дані не валідні");
                return View(model);
            }

        }
    }
}
