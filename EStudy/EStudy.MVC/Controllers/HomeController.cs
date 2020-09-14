using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EStudy.MVC.Models;
using EStudy.Application.Interfaces.MVC;

namespace EStudy.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IIHEService iHEService;
        public HomeController(ILogger<HomeController> logger, IIHEService _iHEService)
        {
            _logger = logger;
            iHEService = _iHEService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
