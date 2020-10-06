using AutoMapper;
using EStudy.Application.Interfaces.MVC;
using EStudy.Application.ViewModels.Schedule;
using EStudy.Application.ViewModels.Schedule.ScheduleAudience;
using EStudy.Application.ViewModels.Schedule.ScheduleDayOfWeek;
using EStudy.Application.ViewModels.Schedule.ScheduleDiscipline;
using EStudy.Application.ViewModels.Schedule.ScheduleGroup;
using EStudy.Application.ViewModels.Schedule.ScheduleLesson;
using EStudy.Application.ViewModels.Schedule.ScheduleParityOfWeek;
using EStudy.Application.ViewModels.Schedule.ScheduleTypeLesson;
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
        private readonly IMapper mapper;

        public ScheduleService(IUnitOfWork _uniOfWork, IMapper _mapper)
        {
            uniOfWork = _uniOfWork;
            mapper = _mapper;
        }

        public async Task<string> AddScheduleAudience(ScheduleAudienceCreateModel model)
        {
            return await uniOfWork.ScheduleAudiences.CreateAsync(new ScheduleAudience
            {
                NameAudience = model.NameAudience,
                NameAudienceEng = model.NameAudienceEng
            });
        }

        public async Task<string> AddScheduleDayOfWeek(ScheduleDayOfWeekCreateModel model)
        {
            return await uniOfWork.ScheduleDayOfWeeks.CreateAsync(new ScheduleDayOfWeek
            {
                Day = model.Day,
                DayEng = model.DayEng
            });
        }

        public async Task<string> AddScheduleDiscipline(ScheduleDisciplineCreateModel model)
        {
            return await uniOfWork.ScheduleDisciplines.CreateAsync(new ScheduleDiscipline
            {
                DisciplineName = model.DisciplineName,
                DisciplineNameEng = model.DisciplineNameEng,
                ShortDisciplineName = model.ShortDisciplineName,
                ShortDisciplineNameEng = model.ShortDisciplineNameEng
            });
        }

        public async Task<string> AddScheduleGroup(ScheduleGroupCreateModel model)
        {
            return await uniOfWork.ScheduleGroups.CreateAsync(new ScheduleGroup
            {
                GroupId = model.GroupId,
                Name = model.Name
            });
        }

        public async Task<string> AddScheduleLesson(ScheduleLessonCreateModel model)
        {
            return await uniOfWork.ScheduleLessons.CreateAsync(new ScheduleLesson
            {
                Number = model.Number,
                Start = model.Start,
                End = model.End
            });
        }

        public async Task<string> AddScheduleParityOfWeek(ScheduleParityOfWeekCreateModel model)
        {
            return await uniOfWork.ScheduleParityOfWeeks.CreateAsync(new ScheduleParityOfWeek
            {
                Week = model.Week,
                WeekEng = model.WeekEng
            });
        }

        public async Task<string> AddScheduleTypeLesson(ScheduleTypeLessonCreateModel model)
        {
            return await uniOfWork.ScheduleTypeLessons.CreateAsync(new ScheduleTypeLesson
            {
                TypeName = model.TypeName,
                ShortTypeName = model.ShortTypeName,
                TypeNameEng = model.TypeNameEng,
                ShortTypeNameEng = model.ShortTypeNameEng
            });
        }

        public async Task<string> CreateSchedule(ScheduleCreateModel model)
        {
            return await uniOfWork.Schedules.CreateAsync(new Schedule
            {
                IsReplacement = model.IsReplacement,
                TeacherId = model.TeacherId,
                DateLesson = model.DateLesson,
                ScheduleDayOfWeekId = model.ScheduleDayOfWeekId,
                ScheduleParityOfWeekId = model.ScheduleParityOfWeekId,
                ScheduleLessonId = model.ScheduleLessonId,
                ScheduleGroupId = model.ScheduleGroupId,
                ScheduleDisciplineId = model.ScheduleDisciplineId,
                ScheduleTypeLessonId = model.ScheduleTypeLessonId,
                ScheduleAudienceId = model.ScheduleAudienceId
            });
        }

        public async Task<string> EditSchedule(ScheduleEditModel model)
        {
            var schedule = await uniOfWork.Schedules.GetByWhereAsTrackingAsync(d => d.Id == model.Id);
            if (schedule == null)
                return "Not found";
            schedule.IsReplacement = model.IsReplacement;
            schedule.TeacherId = model.TeacherId;
            schedule.DateLesson = model.DateLesson;
            schedule.ScheduleDayOfWeekId = model.ScheduleDayOfWeekId;
            schedule.ScheduleParityOfWeekId = model.ScheduleParityOfWeekId;
            schedule.ScheduleLessonId = model.ScheduleLessonId;
            schedule.ScheduleGroupId = model.ScheduleGroupId;
            schedule.ScheduleDisciplineId = model.ScheduleDisciplineId;
            schedule.ScheduleTypeLessonId = model.ScheduleTypeLessonId;
            schedule.ScheduleAudienceId = model.ScheduleAudienceId;
            return await uniOfWork.Schedules.EditAsync(schedule);
        }

        public async Task<string> EditScheduleAudience(ScheduleAudienceEditModel model)
        {
            var scheduleAudience = await uniOfWork.ScheduleAudiences.GetByWhereAsTrackingAsync(d => d.Id == model.Id);
            if (scheduleAudience == null)
                return "Not found";
            scheduleAudience.NameAudience = model.NameAudience;
            scheduleAudience.NameAudienceEng = model.NameAudienceEng;
            scheduleAudience.LastEdited = DateTime.Now;
            return await uniOfWork.ScheduleAudiences.EditAsync(scheduleAudience);
        }

        public async Task<string> EditScheduleDayOfWeek(ScheduleDayOfWeekEditModel model)
        {
            var scheduleDayOfWeek = await uniOfWork.ScheduleDayOfWeeks.GetByWhereAsTrackingAsync(d => d.Id == model.Id);
            if (scheduleDayOfWeek == null)
                return "Not found";
            scheduleDayOfWeek.Day = model.Day;
            scheduleDayOfWeek.DayEng = model.DayEng;
            scheduleDayOfWeek.LastEdited = DateTime.Now;
            return await uniOfWork.ScheduleDayOfWeeks.EditAsync(scheduleDayOfWeek);
        }

        public async Task<string> EditScheduleDiscipline(ScheduleDisciplineEditModel model)
        {
            var scheduleDiscipline = await uniOfWork.ScheduleDisciplines.GetByWhereAsTrackingAsync(d => d.Id == model.Id);
            if (scheduleDiscipline == null)
                return "Not found";
            scheduleDiscipline.DisciplineName = model.DisciplineName;
            scheduleDiscipline.DisciplineNameEng = model.DisciplineNameEng;
            scheduleDiscipline.ShortDisciplineName = model.ShortDisciplineName;
            scheduleDiscipline.ShortDisciplineNameEng = model.ShortDisciplineNameEng;
            scheduleDiscipline.LastEdited = DateTime.Now;
            return await uniOfWork.ScheduleDisciplines.EditAsync(scheduleDiscipline);
        }

        public async Task<string> EditScheduleGroup(ScheduleGroupEditModel model)
        {
            var scheduleGroup = await uniOfWork.ScheduleGroups.GetByWhereAsTrackingAsync(d => d.Id == model.Id);
            if (scheduleGroup == null)
                return "Not found";
            scheduleGroup.GroupId = model.GroupId;
            scheduleGroup.Name = model.Name;
            scheduleGroup.LastEdited = DateTime.Now;
            return await uniOfWork.ScheduleGroups.EditAsync(scheduleGroup);
        }

        public async Task<string> EditScheduleLesson(ScheduleLessonEditModel model)
        {
            var scheduleLesson = await uniOfWork.ScheduleLessons.GetByWhereAsTrackingAsync(d => d.Id == model.Id);
            if (scheduleLesson == null)
                return "Not found";
            scheduleLesson.Start = model.Start;
            scheduleLesson.End = model.End;
            scheduleLesson.Number = model.Number;
            scheduleLesson.LastEdited = DateTime.Now;
            return await uniOfWork.ScheduleLessons.EditAsync(scheduleLesson);
        }

        public async Task<string> EditScheduleParityOfWeek(ScheduleParityOfWeekEditModel model)
        {
            var scheduleParityOfWeek = await uniOfWork.ScheduleParityOfWeeks.GetByWhereAsTrackingAsync(d => d.Id == model.Id);
            if (scheduleParityOfWeek == null)
                return "Not found";
            scheduleParityOfWeek.Week = model.Week;
            scheduleParityOfWeek.WeekEng = model.WeekEng;
            scheduleParityOfWeek.LastEdited = DateTime.Now;
            return await uniOfWork.ScheduleParityOfWeeks.EditAsync(scheduleParityOfWeek);
        }

        public async Task<string> EditScheduleTypeLesson(ScheduleTypeLessonEditModel model)
        {
            var scheduleTypeLesson = await uniOfWork.ScheduleTypeLessons.GetByWhereAsTrackingAsync(d => d.Id == model.Id);
            if (scheduleTypeLesson == null)
                return "Not found";
            scheduleTypeLesson.TypeName = model.TypeName;
            scheduleTypeLesson.TypeNameEng = model.TypeNameEng;
            scheduleTypeLesson.ShortTypeName = model.ShortTypeName;
            scheduleTypeLesson.ShortTypeNameEng = model.ShortTypeNameEng;
            scheduleTypeLesson.LastEdited = DateTime.Now;
            return await uniOfWork.ScheduleTypeLessons.EditAsync(scheduleTypeLesson);
        }

        public async Task<List<ScheduleAudienceViewModel>> GetAllScheduleAudiences()
        {
            return mapper.Map<List<ScheduleAudienceViewModel>>(await uniOfWork.ScheduleAudiences.GetAllAsync());
        }

        public async Task<List<ScheduleDayOfWeekViewModel>> GetAllScheduleDayOfWeeks()
        {
            return mapper.Map<List<ScheduleDayOfWeekViewModel>>(await uniOfWork.ScheduleDayOfWeeks.GetAllAsync());
        }

        public async Task<List<ScheduleDisciplineViewModel>> GetAllScheduleDisciplines()
        {
            return mapper.Map<List<ScheduleDisciplineViewModel>>(await uniOfWork.ScheduleDisciplines.GetAllAsync());
        }

        public async Task<List<ScheduleGroupViewModel>> GetAllScheduleGroups()
        {
            return mapper.Map<List<ScheduleGroupViewModel>>(await uniOfWork.ScheduleGroups.GetAllAsync());
        }

        public async Task<List<ScheduleLessonViewModel>> GetAllScheduleLessons()
        {
            return mapper.Map<List<ScheduleLessonViewModel>>(await uniOfWork.ScheduleLessons.GetAllAsync());
        }

        public async Task<List<ScheduleParityOfWeekViewModel>> GetAllScheduleParityOfWeeks()
        {
            return mapper.Map<List<ScheduleParityOfWeekViewModel>>(await uniOfWork.ScheduleParityOfWeeks.GetAllAsync());
        }

        public async Task<List<ScheduleTypeLessonViewModel>> GetAllScheduleTypeLessons()
        {
            return mapper.Map<List<ScheduleTypeLessonViewModel>>(await uniOfWork.ScheduleTypeLessons.GetAllAsync());
        }

        public async Task<ScheduleViewModel> GetScheduleById(long Id)
        {
            return mapper.Map<ScheduleViewModel>(await uniOfWork.Schedules.GetScheduleByIdAsync(Id));
        }

        public async Task<List<ScheduleViewModel>> GetSchedulesByGroupId(long Id, DateTime date)
        {
            return mapper.Map<List<ScheduleViewModel>>(await uniOfWork.Schedules.GetSchedulesByGroupIdAsync(Id, date));
        }

        public async Task<List<ScheduleViewModel>> GetSchedulesByGroupIdInRange(long Id, DateTime dateFrom, DateTime dateTo)
        {
            return mapper.Map<List<ScheduleViewModel>>(await uniOfWork.Schedules.GetSchedulesByGroupIdInRangeAsync(Id, dateFrom, dateTo));
        }

        public async Task<List<ScheduleViewModel>> GetSchedulesByGroupIdOnWeek(long Id)
        {
            return mapper.Map<List<ScheduleViewModel>>(await uniOfWork.Schedules.GetSchedulesByGroupIdOnWeekAsync(Id));
        }

        public async Task<List<ScheduleViewModel>> GetTodaySchedulesByTeacherId(int Id)
        {
            return mapper.Map<List<ScheduleViewModel>>(await uniOfWork.Schedules.GetTodaySchedulesByTeacherIdAsync(Id));
        }

        public async Task<string> RemoveSchedule(long Id)
        {
            var modelToRemove = await uniOfWork.Schedules.GetByWhereAsTrackingAsync(d => d.Id == Id);
            if (modelToRemove == null)
                return "Not found";
            return await uniOfWork.Schedules.RemoveAsync(modelToRemove);
        }

        public async Task<string> RemoveScheduleAudience(int Id)
        {
            var modelToRemove = await uniOfWork.ScheduleAudiences.GetByWhereAsTrackingAsync(d => d.Id == Id);
            if (modelToRemove == null)
                return "Not found";
            return await uniOfWork.ScheduleAudiences.RemoveAsync(modelToRemove);
        }

        public async Task<string> RemoveScheduleDayOfWeek(int Id)
        {
            var modelToRemove = await uniOfWork.ScheduleDayOfWeeks.GetByWhereAsTrackingAsync(d => d.Id == Id);
            if (modelToRemove == null)
                return "Not found";
            return await uniOfWork.ScheduleDayOfWeeks.RemoveAsync(modelToRemove);
        }

        public async Task<string> RemoveScheduleDiscipline(int Id)
        {
            var modelToRemove = await uniOfWork.ScheduleDisciplines.GetByWhereAsTrackingAsync(d => d.Id == Id);
            if (modelToRemove == null)
                return "Not found";
            return await uniOfWork.ScheduleDisciplines.RemoveAsync(modelToRemove);
        }

        public async Task<string> RemoveScheduleGroup(int Id)
        {
            var modelToRemove = await uniOfWork.ScheduleGroups.GetByWhereAsTrackingAsync(d => d.Id == Id);
            if (modelToRemove == null)
                return "Not found";
            return await uniOfWork.ScheduleGroups.RemoveAsync(modelToRemove);
        }

        public async Task<string> RemoveScheduleLesson(int Id)
        {
            var modelToRemove = await uniOfWork.ScheduleLessons.GetByWhereAsTrackingAsync(d => d.Id == Id);
            if (modelToRemove == null)
                return "Not found";
            return await uniOfWork.ScheduleLessons.RemoveAsync(modelToRemove);
        }

        public async Task<string> RemoveScheduleParityOfWeek(int Id)
        {
            var modelToRemove = await uniOfWork.ScheduleParityOfWeeks.GetByWhereAsTrackingAsync(d => d.Id == Id);
            if (modelToRemove == null)
                return "Not found";
            return await uniOfWork.ScheduleParityOfWeeks.RemoveAsync(modelToRemove);
        }

        public async Task<string> RemoveScheduleTypeLesson(int Id)
        {
            var modelToRemove = await uniOfWork.ScheduleTypeLessons.GetByWhereAsTrackingAsync(d => d.Id == Id);
            if (modelToRemove == null)
                return "Not found";
            return await uniOfWork.ScheduleTypeLessons.RemoveAsync(modelToRemove);
        }
    }
}