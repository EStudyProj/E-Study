using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EStudy.MVC.Controllers
{
    [Route("Admin")]
    public class AdminController : Controller
    {
        private ILogger<AdminController> logger;
        public AdminController(ILogger<AdminController> _logger)
            => logger = _logger;

        [HttpGet("")]
        public IActionResult AdminPanel()
        {
            return View();
        }
    }
}
