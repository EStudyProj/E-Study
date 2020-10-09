﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EStudy.Application.Interfaces.MVC;
using EStudy.Application.ViewModels.Schedule.ScheduleAudience;
using EStudy.Application.ViewModels.Schedule.ScheduleDayOfWeek;
using EStudy.Application.ViewModels.Schedule.ScheduleDiscipline;
using EStudy.Application.ViewModels.Schedule.ScheduleGroup;
using EStudy.Application.ViewModels.Schedule.ScheduleLesson;
using EStudy.Application.ViewModels.Schedule.ScheduleParityOfWeek;
using EStudy.Application.ViewModels.Schedule.ScheduleTeacher;
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

        [HttpGet("/")]
        [HttpGet("")]
        public IActionResult GetSettingSchedule()
        {
            return View();
        }



        #region Audiences
        [HttpGet("Audiences")]
        public async Task<IActionResult> GetAllAudience()
        {
            return View(await scheduleService.GetAllScheduleAudiences());
        }

        [HttpGet("CreateAudience")]
        public IActionResult CreateAudience()
        {
            return View();
        }

        [HttpPost("CreateAudience")]
        public async Task<IActionResult> CreateAudience(ScheduleAudienceCreateModel model)
        {
            if (await scheduleService.AddScheduleAudience(model) == "OK")
                return LocalRedirect("~/Schedule/Audiences");
            return View("Error");
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
            return LocalRedirect("~/Schedule/Audiences");
        }

        [HttpGet("DeleteAudience")]
        public async Task<IActionResult> DeleteAudience(int Id)
        {
            if (await scheduleService.RemoveScheduleAudience(Id) != "OK")
                return View("Error");
            return LocalRedirect("~/Schedule/Audiences");
        }
        #endregion


        #region DayOfWeek
        [HttpGet("DayOfWeeks")]
        public async Task<IActionResult> GetAllDayOfWeek()
        {
            return View(await scheduleService.GetAllScheduleDayOfWeeks());
        }

        [HttpGet("CreateDayOfWeek")]
        public IActionResult CreateDayOfWeek()
        {
            return View();
        }

        [HttpPost("CreateDayOfWeek")]
        public async Task<IActionResult> CreateDayOfWeek(ScheduleDayOfWeekCreateModel model)
        {
            if (await scheduleService.AddScheduleDayOfWeek(model) == "OK")
                return LocalRedirect("~/Schedule/DayOfWeeks");
            return View("Error");
        }

        [HttpGet("EditDayOfWeek")]
        public async Task<IActionResult> EditDayOfWeek(int Id)
        {
            var dayOfWeek = await scheduleService.GetScheduleDayOfWeekForEdit(Id);
            if (dayOfWeek == null)
                return View("Error");
            return View(dayOfWeek);
        }

        [HttpPost("EditDayOfWeek")]
        public async Task<IActionResult> EditDayOfWeek(ScheduleDayOfWeekEditModel model)
        {
            if (!ModelState.IsValid)
                return View(model);
            if (await scheduleService.EditScheduleDayOfWeek(model) != "OK")
                return View("Error");
            return LocalRedirect("~/Schedule/DayOfWeeks");
        }

        [HttpGet("DeleteDayOfWeek")]
        public async Task<IActionResult> DeleteDayOfWeek(int Id)
        {
            if (await scheduleService.RemoveScheduleDayOfWeek(Id) != "OK")
                return View("Error");
            return LocalRedirect("~/Schedule/Audiences");
        }
        #endregion


        #region Discipline
        [HttpGet("Disciplines")]
        public async Task<IActionResult> GetAllDiscipline()
        {
            return View(await scheduleService.GetAllScheduleDisciplines());
        }

        [HttpGet("CreateDiscipline")]
        public IActionResult CreateDiscipline()
        {
            return View();
        }

        [HttpPost("CreateDiscipline")]
        public async Task<IActionResult> CreateDiscipline(ScheduleDisciplineCreateModel model)
        {
            if (await scheduleService.AddScheduleDiscipline(model) == "OK")
                return LocalRedirect("~/Schedule/Disciplines");
            return View("Error");
        }

        [HttpGet("EditDiscipline")]
        public async Task<IActionResult> EditDiscipline(int Id)
        {
            var discipline = await scheduleService.GetScheduleDisciplineForEdit(Id);
            if (discipline == null)
                return View("Error");
            return View(discipline);
        }

        [HttpPost("EditDiscipline")]
        public async Task<IActionResult> EditDiscipline(ScheduleDisciplineEditModel model)
        {
            if (!ModelState.IsValid)
                return View(model);
            if (await scheduleService.EditScheduleDiscipline(model) != "OK")
                return View("Error");
            return LocalRedirect("~/Schedule/Disciplines");
        }

        [HttpGet("DeleteDiscipline")]
        public async Task<IActionResult> DeleteDiscipline(int Id)
        {
            if (await scheduleService.RemoveScheduleDiscipline(Id) != "OK")
                return View("Error");
            return LocalRedirect("~/Schedule/Disciplines");
        }
        #endregion


        #region Group
        [HttpGet("Groups")]
        public async Task<IActionResult> GetAllGroup()
        {
            return View(await scheduleService.GetAllScheduleGroups());
        }

        [HttpGet("CreateGroup")]
        public IActionResult CreateGroup()
        {
            return View();
        }

        [HttpPost("CreateGroup")]
        public async Task<IActionResult> CreateGroup(ScheduleGroupCreateModel model)
        {
            if (await scheduleService.AddScheduleGroup(model) == "OK")
                return LocalRedirect("~/Schedule/Groups");
            return View("Error");
        }

        [HttpGet("EditGroup")]
        public async Task<IActionResult> EditGroup(int Id)
        {
            var group = await scheduleService.GetScheduleGroupForEdit(Id);
            if (group == null)
                return View("Error");
            return View(group);
        }

        [HttpPost("EditGroup")]
        public async Task<IActionResult> EditGroup(ScheduleGroupEditModel model)
        {
            if (!ModelState.IsValid)
                return View(model);
            if (await scheduleService.EditScheduleGroup(model) != "OK")
                return View("Error");
            return LocalRedirect("~/Schedule/Groups");
        }

        [HttpGet("DeleteGroup")]
        public async Task<IActionResult> DeleteGroup(int Id)
        {
            if (await scheduleService.RemoveScheduleGroup(Id) != "OK")
                return View("Error");
            return LocalRedirect("~/Schedule/Groups");
        }
        #endregion


        #region Lesson
        [HttpGet("Lessons")]
        public async Task<IActionResult> GetAllLesson()
        {
            return View(await scheduleService.GetAllScheduleLessons());
        }

        [HttpGet("CreateLesson")]
        public IActionResult CreateLesson()
        {
            return View();
        }

        [HttpPost("CreateLesson")]
        public async Task<IActionResult> CreateLesson(ScheduleLessonCreateModel model)
        {
            if (await scheduleService.AddScheduleLesson(model) == "OK")
                return LocalRedirect("~/Schedule/Lessons");
            return View("Error");
        }

        [HttpGet("EditLesson")]
        public async Task<IActionResult> EditLesson(int Id)
        {
            var lesson = await scheduleService.GetScheduleLessonForEdit(Id);
            if (lesson == null)
                return View("Error");
            return View(lesson);
        }

        [HttpPost("EditLesson")]
        public async Task<IActionResult> EditLesson(ScheduleLessonEditModel model)
        {
            if (!ModelState.IsValid)
                return View(model);
            if (await scheduleService.EditScheduleLesson(model) != "OK")
                return View("Error");
            return LocalRedirect("~/Schedule/Lessons");
        }

        [HttpGet("DeleteLesson")]
        public async Task<IActionResult> DeleteLesson(int Id)
        {
            if (await scheduleService.RemoveScheduleLesson(Id) != "OK")
                return View("Error");
            return LocalRedirect("~/Schedule/Lessons");
        }
        #endregion


        #region ParityOfWeek
        [HttpGet("ParityOfWeeks")]
        public async Task<IActionResult> GetAllParityOfWeek()
        {
            return View(await scheduleService.GetAllScheduleParityOfWeeks());
        }

        [HttpGet("CreateParityOfWeek")]
        public IActionResult CreateParityOfWeek()
        {
            return View();
        }

        [HttpPost("CreateParityOfWeek")]
        public async Task<IActionResult> CreateParityOfWeek(ScheduleParityOfWeekCreateModel model)
        {
            if (await scheduleService.AddScheduleParityOfWeek(model) == "OK")
                return LocalRedirect("~/Schedule/ParityOfWeeks");
            return View("Error");
        }

        [HttpGet("EditParityOfWeek")]
        public async Task<IActionResult> EditParityOfWeek(int Id)
        {
            var parityOfWeek = await scheduleService.GetScheduleParityOfWeekForEdit(Id);
            if (parityOfWeek == null)
                return View("Error");
            return View(parityOfWeek);
        }

        [HttpPost("EditParityOfWeek")]
        public async Task<IActionResult> EditParityOfWeek(ScheduleParityOfWeekEditModel model)
        {
            if (!ModelState.IsValid)
                return View(model);
            if (await scheduleService.EditScheduleParityOfWeek(model) != "OK")
                return View("Error");
            return LocalRedirect("~/Schedule/ParityOfWeeks");
        }

        [HttpGet("DeleteParityOfWeek")]
        public async Task<IActionResult> DeleteParityOfWeek(int Id)
        {
            if (await scheduleService.RemoveScheduleParityOfWeek(Id) != "OK")
                return View("Error");
            return LocalRedirect("~/Schedule/ParityOfWeeks");
        }
        #endregion


        #region Teachers
        [HttpGet("Teachers")]
        public async Task<IActionResult> GetAllTeacher()
        {
            return View(await scheduleService.GetAllScheduleTeachers());
        }

        [HttpGet("CreateTeacher")]
        public IActionResult CreateTeacher()
        {
            return View();
        }

        [HttpPost("CreateTeacher")]
        public async Task<IActionResult> CreateTeacher(ScheduleTeacherCreateModel model)
        {
            if (await scheduleService.AddScheduleTeacher(model) == "OK")
                return LocalRedirect("~/Schedule/Teachers");
            return View("Error");
        }

        [HttpGet("EditTeacher")]
        public async Task<IActionResult> EditTeacher(int Id)
        {
            var teacher = await scheduleService.GetScheduleTeacherForEdit(Id);
            if (teacher == null)
                return View("Error");
            return View(teacher);
        }

        [HttpPost("EditTeacher")]
        public async Task<IActionResult> EditTeacher(ScheduleTeacherEditModel model)
        {
            if (!ModelState.IsValid)
                return View(model);
            if (await scheduleService.EditScheduleTeacher(model) != "OK")
                return View("Error");
            return LocalRedirect("~/Schedule/Teachers");
        }

        [HttpGet("DeleteTeacher")]
        public async Task<IActionResult> DeleteTeacher(int Id)
        {
            if (await scheduleService.RemoveScheduleTeacher(Id) != "OK")
                return View("Error");
            return LocalRedirect("~/Schedule/Teachers");
        }
        #endregion
    }
}