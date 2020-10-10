using EStudy.Application.ViewModels.Schedule;
using EStudy.Application.ViewModels.Schedule.ScheduleAudience;
using EStudy.Application.ViewModels.Schedule.ScheduleDayOfWeek;
using EStudy.Application.ViewModels.Schedule.ScheduleDiscipline;
using EStudy.Application.ViewModels.Schedule.ScheduleGroup;
using EStudy.Application.ViewModels.Schedule.ScheduleLesson;
using EStudy.Application.ViewModels.Schedule.ScheduleParityOfWeek;
using EStudy.Application.ViewModels.Schedule.ScheduleTeacher;
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
        Task<string> RemoveAllAudiences();
        Task<ScheduleAudienceEditModel> GetScheduleAudienceForEdit(int Id);
        Task<List<ScheduleAudienceViewModel>> GetAllScheduleAudiences();

        Task<string> AddScheduleDayOfWeek(ScheduleDayOfWeekCreateModel model);
        Task<string> EditScheduleDayOfWeek(ScheduleDayOfWeekEditModel model);
        Task<string> RemoveScheduleDayOfWeek(int Id);
        Task<string> RemoveAllDayOfWeeks();
        Task<ScheduleDayOfWeekEditModel> GetScheduleDayOfWeekForEdit(int Id);
        Task<List<ScheduleDayOfWeekViewModel>> GetAllScheduleDayOfWeeks();

        Task<string> AddScheduleDiscipline(ScheduleDisciplineCreateModel model);
        Task<string> EditScheduleDiscipline(ScheduleDisciplineEditModel model);
        Task<string> RemoveScheduleDiscipline(int Id);
        Task<string> RemoveAllDisciplines();
        Task<ScheduleDisciplineEditModel> GetScheduleDisciplineForEdit(int Id);
        Task<List<ScheduleDisciplineViewModel>> GetAllScheduleDisciplines();

        Task<string> AddScheduleGroup(ScheduleGroupCreateModel model);
        Task<string> EditScheduleGroup(ScheduleGroupEditModel model);
        Task<string> RemoveScheduleGroup(int Id);
        Task<string> RemoveAllGroups();
        Task<ScheduleGroupEditModel> GetScheduleGroupForEdit(int Id);
        Task<List<ScheduleGroupViewModel>> GetAllScheduleGroups();

        Task<string> AddScheduleLesson(ScheduleLessonCreateModel model);
        Task<string> EditScheduleLesson(ScheduleLessonEditModel model);
        Task<string> RemoveScheduleLesson(int Id);
        Task<string> RemoveAllLessons();
        Task<ScheduleLessonEditModel> GetScheduleLessonForEdit(int Id);
        Task<List<ScheduleLessonViewModel>> GetAllScheduleLessons();

        Task<string> AddScheduleParityOfWeek(ScheduleParityOfWeekCreateModel model);
        Task<string> EditScheduleParityOfWeek(ScheduleParityOfWeekEditModel model);
        Task<string> RemoveScheduleParityOfWeek(int Id);
        Task<string> RemoveAllParityOfWeeks();
        Task<ScheduleParityOfWeekEditModel> GetScheduleParityOfWeekForEdit(int Id);
        Task<List<ScheduleParityOfWeekViewModel>> GetAllScheduleParityOfWeeks();

        Task<string> AddScheduleTeacher(ScheduleTeacherCreateModel model);
        Task<string> EditScheduleTeacher(ScheduleTeacherEditModel model);
        Task<string> RemoveScheduleTeacher(int Id);
        Task<string> RemoveAllTeachers();
        Task<ScheduleTeacherEditModel> GetScheduleTeacherForEdit(int Id);
        Task<List<ScheduleTeacherViewModel>> GetAllScheduleTeachers();

        Task<string> AddScheduleTypeLesson(ScheduleTypeLessonCreateModel model);
        Task<string> EditScheduleTypeLesson(ScheduleTypeLessonEditModel model);
        Task<string> RemoveScheduleTypeLesson(int Id);
        Task<string> RemoveAllTypeLessons();
        Task<ScheduleTypeLessonEditModel> GetScheduleTypeLessonForEdit(int Id);
        Task<List<ScheduleTypeLessonViewModel>> GetAllScheduleTypeLessons();
        #endregion

        Task<ScheduleViewModel> GetScheduleById(long Id);
        Task<ScheduleEditModel> GetScheduleForEdit(long Id);
        Task<ScheduleListEntitiesViewModel> GetAllData();
        Task<List<ScheduleViewModel>> GetLastAddedSchedule(int count);
        Task<List<ScheduleViewModel>> GetLastEditedSchedule(int count);


        Task<string> CreateSchedule(ScheduleCreateModel model);
        Task<string> EditSchedule(ScheduleEditModel model);
        Task<string> RemoveSchedule(long Id);
    }
}