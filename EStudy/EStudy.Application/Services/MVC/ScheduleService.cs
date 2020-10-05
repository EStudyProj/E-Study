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

        public async Task<string> EditScheduleAudience(ScheduleAudienceEditModel model)
        {
            throw new NotImplementedException();
        }

        public async Task<string> EditScheduleDayOfWeek(ScheduleDayOfWeekEditModel model)
        {
            throw new NotImplementedException();
        }

        public async Task<string> EditScheduleDiscipline(ScheduleDisciplineEditModel model)
        {
            throw new NotImplementedException();
        }

        public async Task<string> EditScheduleGroup(ScheduleGroupEditModel model)
        {
            throw new NotImplementedException();
        }

        public async Task<string> EditScheduleLesson(ScheduleLessonEditModel model)
        {
            throw new NotImplementedException();
        }

        public async Task<string> EditScheduleParityOfWeek(ScheduleParityOfWeekEditModel model)
        {
            throw new NotImplementedException();
        }

        public async Task<string> EditScheduleTypeLesson(ScheduleTypeLessonEditModel model)
        {
            throw new NotImplementedException();
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

        public async Task<string> RemoveScheduleAudience(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<string> RemoveScheduleDayOfWeek(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<string> RemoveScheduleDiscipline(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<string> RemoveScheduleGroup(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<string> RemoveScheduleLesson(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<string> RemoveScheduleParityOfWeek(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<string> RemoveScheduleTypeLesson(int Id)
        {
            throw new NotImplementedException();
        }
    }
}