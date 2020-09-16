using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EStudy.Application.Interfaces.MVC;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EStudy.MVC.Controllers
{
    [Route("User")]
    public class UserController : Controller
    {
        private readonly ILogger<UserController> _logger;
        private IUserService userService;
        public UserController(ILogger<UserController> logger, IUserService _userService)
        {
            _logger = logger;
            userService = _userService;
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetUser(int Id)
        {
            var user = await userService.GetUserById(Id);
            if (user == null)
                return View("Error");
            return View(user);
        }
    }
}
