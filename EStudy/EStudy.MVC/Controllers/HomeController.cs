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
        private ITestService testService;
        public HomeController(ILogger<HomeController> logger, ITestService _testService)
        {
            _logger = logger;
            testService = _testService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet("tests")]
        public async Task<IActionResult> GetTests()
        {
            return Ok(await testService.GetAll());
        }

        [HttpGet("create")]
        public async Task<IActionResult> Create()
        {
            await testService.CreateTestData();
            return Ok();
        }
    }
}
