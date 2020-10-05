using EStudy.Application.ViewModels.Schedule;
using EStudy.Application.ViewModels.Schedule.ScheduleAudience;
using EStudy.Application.ViewModels.Schedule.ScheduleDayOfWeek;
using EStudy.Application.ViewModels.Schedule.ScheduleDiscipline;
using EStudy.Application.ViewModels.Schedule.ScheduleGroup;
using EStudy.Application.ViewModels.Schedule.ScheduleLesson;
using EStudy.Application.ViewModels.Schedule.ScheduleParityOfWeek;
using EStudy.Application.ViewModels.Schedule.ScheduleTypeLesson;
using EStudy.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EStudy.Application.Interfaces.MVC
{
    public interface IScheduleService
    {
        #region ScheduleCRUD
        Task<string> AddScheduleAudience(ScheduleAudienceCreateModel model);
        Task<string> EditScheduleAudience(ScheduleAudienceEditModel model);
        Task<string> RemoveScheduleAudience(int Id);
        Task<string> AddScheduleDayOfWeek(ScheduleDayOfWeekCreateModel model);
        Task<string> EditScheduleDayOfWeek(ScheduleDayOfWeekEditModel model);
        Task<string> RemoveScheduleDayOfWeek(int Id);
        Task<string> AddScheduleDiscipline(ScheduleDisciplineCreateModel model);
        Task<string> EditScheduleDiscipline(ScheduleDisciplineEditModel model);
        Task<string> RemoveScheduleDiscipline(int Id);
        Task<string> AddScheduleGroup(ScheduleGroupCreateModel model);
        Task<string> EditScheduleGroup(ScheduleGroupEditModel model);
        Task<string> RemoveScheduleGroup(int Id);
        Task<string> AddScheduleLesson(ScheduleLessonCreateModel model);
        Task<string> EditScheduleLesson(ScheduleLessonEditModel model);
        Task<string> RemoveScheduleLesson(int Id);
        Task<string> AddScheduleParityOfWeek(ScheduleParityOfWeekCreateModel model);
        Task<string> EditScheduleParityOfWeek(ScheduleParityOfWeekEditModel model);
        Task<string> RemoveScheduleParityOfWeek(int Id);
        Task<string> AddScheduleTypeLesson(ScheduleTypeLessonCreateModel model);
        Task<string> EditScheduleTypeLesson(ScheduleTypeLessonEditModel model);
        Task<string> RemoveScheduleTypeLesson(int Id);
        #endregion

        Task<ScheduleViewModel> GetScheduleById(long Id);
        Task<List<ScheduleViewModel>> GetSchedulesByGroupId(long Id, DateTime date);
        Task<List<ScheduleViewModel>> GetSchedulesByGroupIdOnWeek(long Id);
        Task<List<ScheduleViewModel>> GetSchedulesByGroupIdInRange(long Id, DateTime dateFrom, DateTime dateTo);
        Task<List<ScheduleViewModel>> GetTodaySchedulesByTeacherId(int Id);
    }
}