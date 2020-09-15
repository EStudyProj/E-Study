using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EStudy.Application.Interfaces.MVC;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EStudy.MVC.Controllers
{
    public class TestController : Controller
    {
        private readonly ILogger<TestController> _logger;
        private ITestService testService;
        public TestController(ILogger<TestController> logger, ITestService _testService)
        {
            _logger = logger;
            testService = _testService;
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
