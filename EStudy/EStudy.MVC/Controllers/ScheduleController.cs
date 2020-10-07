using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EStudy.Application.Interfaces.MVC;
using EStudy.Application.ViewModels.Schedule.ScheduleAudience;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EStudy.MVC.Controllers
{
    [Route("Schedule")]
    public class ScheduleController : Controller
    {
        private ILogger<ScheduleController> logger;
        private IScheduleService scheduleService;
        public ScheduleController(ILogger<ScheduleController> _logger, IScheduleService _scheduleService)
        {
            logger = _logger;
            scheduleService = _scheduleService;
        }

        [HttpGet("TeacherToday/{TeacherId}")]
        public async Task<IActionResult> GetTodayScheduleByTeacherId(int TeacherId)
        {
            var scheduls = await scheduleService.GetTodaySchedulesByTeacherId(TeacherId);
            return View(scheduls);
        }



























        [HttpGet("AllAudiences")]
        public async Task<IActionResult> GetAllAudience()
        {
            return View(await scheduleService.GetAllScheduleAudiences());
        }

        [HttpGet("EditAudience")]
        public async Task<IActionResult> EditAudience(int Id)
        {
            var audience = await scheduleService.GetScheduleAudienceForEdit(Id);
            if (audience == null)
                return View("Error");
            return View(audience);
        }

        [HttpPost("EditAudience")]
        public async Task<IActionResult> EditAudience(ScheduleAudienceEditModel model)
        {
            if (!ModelState.IsValid)
                return View(model);
            if (await scheduleService.EditScheduleAudience(model) != "OK")
                return View("Error");
            return LocalRedirect("~/Schedule/AllAudiences");
        }
    }
}