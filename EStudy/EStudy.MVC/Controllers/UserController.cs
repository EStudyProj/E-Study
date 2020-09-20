using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EStudy.Application.Interfaces.MVC;
using EStudy.Application.ViewModels.User;
using Microsoft.AspNetCore.Authorization;
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
            if (Id == GetCurrentId())
                return LocalRedirect("~/Me");
            var user = await userService.GetUserById(Id);
            if (user == null)
                return View("Error");
            return View(user);
        }

        [HttpGet("Search")]
        public async Task<IActionResult> Search(string name, int count = 10, int offset = 0)
        {
            List<UserShortViewModel> users;
            if (string.IsNullOrEmpty(name))
                users = await userService.GetLastUsers();
            else
                users = await userService.SearchUsers(name, count, offset);
            return View(users);
        }

        [HttpGet("Settings")]
        public IActionResult Settings()
        {
            return View();
        }

        [HttpGet("Edit")]
        public async Task<IActionResult> Edit(int? Id)
        {
            UserViewModel editUser = new UserViewModel();
            if (Id == null)
            {
                editUser = await userService.GetUserById(GetCurrentId());
                ViewBag.Id = 0;
            }
            else
            {
                editUser = await userService.GetUserById(Convert.ToInt32(Id));
                ViewBag.Id = Id;
            }
            if (editUser == null)
                return View("Error");
            return View(new UserEditNamesModel
            {
                Firstname = editUser.Firstname,
                Patronymic = editUser.Patronymic,
                Lastname = editUser.Lastname
            });
        }

        [HttpPost("Edit")]
        public async Task<IActionResult> Edit(UserEditNamesModel model)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("","Дані не валідні");
                return View();
            }

            int currentId = Convert.ToInt32(User.Claims.FirstOrDefault(d => d.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier").Value);
            if (model.Id == default)
                model.Id = currentId;
            model.IPAddress = HttpContext.Connection.RemoteIpAddress.ToString();
            model.UserEditId = currentId;
            var res = await userService.ChangeNames(model);
            if (res == "OK")
                return View("Settings");
            else
            {
                ModelState.AddModelError("", res);
                return View(model);
            }
        }

        public int GetCurrentId()
        {
            try
            {
                return Convert.ToInt32(User.Claims.FirstOrDefault(d => d.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier").Value);
            }
            catch
            {
                return 0;
            }
        }
    }
}
