using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EStudy.Application.Interfaces.MVC;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EStudy.MVC.Controllers
{
    [Route("Diploma")]
    public class DiplomaController : Controller
    {
        private ILogger<DiplomaController> logger;
        private IDiplomaService diplomaService;
        public DiplomaController(ILogger<DiplomaController> _logger, IDiplomaService _diplomaService)
        {
            logger = _logger;
            diplomaService = _diplomaService;
        }

        [HttpGet("{code}")]
        public async Task<IActionResult> Index(string code)
        {
            return Ok(await diplomaService.GetByCode(code));
        }
    }
}
