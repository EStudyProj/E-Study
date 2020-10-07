using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EStudy.Application.Interfaces.MVC;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EStudy.MVC.Controllers
{
    public class ScheduleController : Controller
    {
        private ILogger<ScheduleController> logger;
        private IScheduleService scheduleService;
        public ScheduleController(ILogger<ScheduleController> _logger, IScheduleService _scheduleService)
        {
            logger = _logger;
            scheduleService = _scheduleService;
        }

        [HttpGet("Schedule/TeacherToday/{TeacherId}")]
        public async Task<IActionResult> GetTodayScheduleByTeacherId(int TeacherId)
        {
            var scheduls = await scheduleService.GetTodaySchedulesByTeacherId(TeacherId);
            return View(scheduls);
        }



























        [HttpGet("Schedule/AllAudience")]
        public async Task<IActionResult> GetAllAudience()
        {
            return View(await scheduleService.GetAllScheduleAudiences());
        }
    }
}