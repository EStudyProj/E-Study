using EStudy.Application.Interfaces.MVC;
using EStudy.Application.ViewModels.Schedule;
using EStudy.Domain.Models;
using EStudy.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EStudy.Application.Services.MVC
{
    public class ScheduleService : IScheduleService
    {
        private readonly IUnitOfWork uniOfWork;

        public ScheduleService(IUnitOfWork _uniOfWork)
        {
            uniOfWork = _uniOfWork;
        }

        #region AddOperation
        public async Task<string> AddScheduleAudience(ScheduleAudience model)
        {
            return await uniOfWork.ScheduleAudiences.CreateAsync(model);
        }

        public async Task<string> AddScheduleDayOfWeek(ScheduleDayOfWeek model)
        {
            return await uniOfWork.ScheduleDayOfWeeks.CreateAsync(model);
        }

        public async Task<string> AddScheduleDiscipline(ScheduleDiscipline model)
        {
            return await uniOfWork.ScheduleDisciplines.CreateAsync(model);
        }

        public async Task<string> AddScheduleGroup(ScheduleGroup model)
        {
            return await uniOfWork.ScheduleGroups.CreateAsync(model);
        }

        public async Task<string> AddScheduleLesson(ScheduleLesson model)
        {
            return await uniOfWork.ScheduleLessons.CreateAsync(model);
        }

        public async Task<string> AddScheduleParityOfWeek(ScheduleParityOfWeek model)
        {
            return await uniOfWork.ScheduleParityOfWeeks.CreateAsync(model);
        }

        public async Task<string> AddScheduleTypeLesson(ScheduleTypeLesson model)
        {
            return await uniOfWork.ScheduleTypeLessons.CreateAsync(model);
        }
        #endregion

        #region EditOperation
        public async Task<string> EditScheduleAudience(ScheduleAudience model)
        {
            return await uniOfWork.ScheduleAudiences.EditAsync(model);
        }

        public async Task<string> EditScheduleDayOfWeek(ScheduleDayOfWeek model)
        {
            return await uniOfWork.ScheduleDayOfWeeks.EditAsync(model);
        }

        public async Task<string> EditScheduleDiscipline(ScheduleDiscipline model)
        {
            return await uniOfWork.ScheduleDisciplines.EditAsync(model);
        }

        public async Task<string> EditScheduleGroup(ScheduleGroup model)
        {
            return await uniOfWork.ScheduleGroups.EditAsync(model);
        }

        public async Task<string> EditScheduleLesson(ScheduleLesson model)
        {
            return await uniOfWork.ScheduleLessons.EditAsync(model);
        }

        public async Task<string> EditScheduleParityOfWeek(ScheduleParityOfWeek model)
        {
            return await uniOfWork.ScheduleParityOfWeeks.EditAsync(model);
        }

        public async Task<string> EditScheduleTypeLesson(ScheduleTypeLesson model)
        {
            return await uniOfWork.ScheduleTypeLessons.EditAsync(model);
        }
        #endregion

        #region RemoveOperation
        public async Task<string> RemoveScheduleAudience(int Id)
        {
            var model = await uniOfWork.ScheduleAudiences.GetByWhereAsTrackingAsync(d => d.Id == Id);
            if (model == null)
                return "Not found";
            return await uniOfWork.ScheduleAudiences.RemoveAsync(model);
        }

        public async Task<string> RemoveScheduleDayOfWeek(int Id)
        {
            var model = await uniOfWork.ScheduleDayOfWeeks.GetByWhereAsTrackingAsync(d => d.Id == Id);
            if (model == null)
                return "Not found";
            return await uniOfWork.ScheduleDayOfWeeks.RemoveAsync(model);
        }

        public async Task<string> RemoveScheduleDiscipline(int Id)
        {
            var model = await uniOfWork.ScheduleDisciplines.GetByWhereAsTrackingAsync(d => d.Id == Id);
            if (model == null)
                return "Not found";
            return await uniOfWork.ScheduleDisciplines.RemoveAsync(model);
        }

        public async Task<string> RemoveScheduleGroup(int Id)
        {
            var model = await uniOfWork.ScheduleGroups.GetByWhereAsTrackingAsync(d => d.Id == Id);
            if (model == null)
                return "Not found";
            return await uniOfWork.ScheduleGroups.RemoveAsync(model);
        }

        public async Task<string> RemoveScheduleLesson(int Id)
        {
            var model = await uniOfWork.ScheduleLessons.GetByWhereAsTrackingAsync(d => d.Id == Id);
            if (model == null)
                return "Not found";
            return await uniOfWork.ScheduleLessons.RemoveAsync(model);
        }

        public async Task<string> RemoveScheduleParityOfWeek(int Id)
        {
            var model = await uniOfWork.ScheduleParityOfWeeks.GetByWhereAsTrackingAsync(d => d.Id == Id);
            if (model == null)
                return "Not found";
            return await uniOfWork.ScheduleParityOfWeeks.RemoveAsync(model);
        }

        public async Task<string> RemoveScheduleTypeLesson(int Id)
        {
            var model = await uniOfWork.ScheduleTypeLessons.GetByWhereAsTrackingAsync(d => d.Id == Id);
            if (model == null)
                return "Not found";
            return await uniOfWork.ScheduleTypeLessons.RemoveAsync(model);
        }
        #endregion


        public async Task<ScheduleViewModel> GetScheduleById(long Id)
        {
            return Mapper.GetSchedule(await uniOfWork.Schedules.GetScheduleByIdAsync(Id));
        }

        public async Task<List<ScheduleViewModel>> GetSchedulesByGroupId(long Id, DateTime date)
        {
            return Mapper.GetSchedules(await uniOfWork.Schedules.GetSchedulesByGroupIdAsync(Id, date));
        }

        public async Task<List<ScheduleViewModel>> GetSchedulesByGroupIdInRange(long Id, DateTime dateFrom, DateTime dateTo)
        {
            return Mapper.GetSchedules(await uniOfWork.Schedules.GetSchedulesByGroupIdInRangeAsync(Id, dateFrom, dateTo));
        }

        public async Task<List<ScheduleViewModel>> GetSchedulesByGroupIdOnWeek(long Id)
        {
            return Mapper.GetSchedules(await uniOfWork.Schedules.GetSchedulesByGroupIdOnWeekAsync(Id));
        }
    }
}