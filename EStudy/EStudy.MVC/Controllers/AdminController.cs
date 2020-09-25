using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EStudy.Application.Interfaces.MVC;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EStudy.MVC.Controllers
{
    [Route("Admin")]
    public class AdminController : Controller
    {
        private ILogger<AdminController> logger;
        private IAdminService adminService;
        public AdminController(ILogger<AdminController> _logger, IAdminService _adminService)
        {
            logger = _logger;
            adminService = _adminService;
        }


        [HttpGet("")]
        public IActionResult AdminPanel()
        {
            return View();
        }

        [HttpGet("CreateDb")]
        public async Task<IActionResult> CreateDb()
        {
            var res = await adminService.CreateDatabase();
            if (res)
                ViewBag.Res = "OK";
            else
                ViewBag.Res = "Some error";
            return View("AdminPanel");
        }

        [HttpGet("CreateData")]
        public async Task<IActionResult> CreateData()
        {
            var res = await adminService.CreateTestData();
            ViewBag.Res = res;
            return View("AdminPanel");
        }

        [HttpGet("DropDb")]
        public async Task<IActionResult> DropDb()
        {
            var res = await adminService.DropDatabase();
            if (res)
                ViewBag.Res = "OK";
            else
                ViewBag.Res = "Some error";
            return View("AdminPanel");
        }


        [HttpGet("Pay")]
        public IActionResult PaySub()
        {
            return View();
        }
    }
}
