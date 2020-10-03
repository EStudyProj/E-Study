using EStudy.Application.ViewModels.Schedule;
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
        Task<string> AddScheduleAudience(ScheduleAudience model);
        Task<string> EditScheduleAudience(ScheduleAudience model);
        Task<string> RemoveScheduleAudience(int Id);
        Task<string> AddScheduleDayOfWeek(ScheduleDayOfWeek model);
        Task<string> EditScheduleDayOfWeek(ScheduleDayOfWeek model);
        Task<string> RemoveScheduleDayOfWeek(int Id);
        Task<string> AddScheduleDiscipline(ScheduleDiscipline model);
        Task<string> EditScheduleDiscipline(ScheduleDiscipline model);
        Task<string> RemoveScheduleDiscipline(int Id);
        Task<string> AddScheduleGroup(ScheduleGroup model);
        Task<string> EditScheduleGroup(ScheduleGroup model);
        Task<string> RemoveScheduleGroup(int Id);
        Task<string> AddScheduleLesson(ScheduleLesson model);
        Task<string> EditScheduleLesson(ScheduleLesson model);
        Task<string> RemoveScheduleLesson(int Id);
        Task<string> AddScheduleParityOfWeek(ScheduleParityOfWeek model);
        Task<string> EditScheduleParityOfWeek(ScheduleParityOfWeek model);
        Task<string> RemoveScheduleParityOfWeek(int Id);
        Task<string> AddScheduleTypeLesson(ScheduleTypeLesson model);
        Task<string> EditScheduleTypeLesson(ScheduleTypeLesson model);
        Task<string> RemoveScheduleTypeLesson(int Id);
        #endregion

        Task<ScheduleViewModel> GetScheduleById(long Id);
        Task<List<ScheduleViewModel>> GetSchedulesByGroupId(long Id, DateTime date);
        Task<List<ScheduleViewModel>> GetSchedulesByGroupIdOnWeek(long Id);
        Task<List<ScheduleViewModel>> GetSchedulesByGroupIdInRange(long Id, DateTime dateFrom, DateTime dateTo);
    }
}