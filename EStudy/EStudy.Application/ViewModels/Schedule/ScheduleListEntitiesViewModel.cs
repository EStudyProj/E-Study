using EStudy.Application.ViewModels.Schedule.ScheduleAudience;
using EStudy.Application.ViewModels.Schedule.ScheduleDayOfWeek;
using EStudy.Application.ViewModels.Schedule.ScheduleDiscipline;
using EStudy.Application.ViewModels.Schedule.ScheduleGroup;
using EStudy.Application.ViewModels.Schedule.ScheduleLesson;
using EStudy.Application.ViewModels.Schedule.ScheduleParityOfWeek;
using EStudy.Application.ViewModels.Schedule.ScheduleTeacher;
using EStudy.Application.ViewModels.Schedule.ScheduleTypeLesson;
using System;
using System.Collections.Generic;
using System.Text;
namespace EStudy.Application.ViewModels.Schedule
{
    public class ScheduleListEntitiesViewModel
    {
        public List<ScheduleAudienceViewModel> ScheduleAudiences { get; set; }
        public List<ScheduleDayOfWeekViewModel> ScheduleDayOfWeeks { get; set; }
        public List<ScheduleDisciplineViewModel> ScheduleDisciplines { get; set; }
        public List<ScheduleGroupViewModel> ScheduleGroups { get; set; }
        public List<ScheduleLessonViewModel> ScheduleLessons { get; set; }
        public List<ScheduleParityOfWeekViewModel> ScheduleParityOfWeeks { get; set; }
        public List<ScheduleTeacherViewModel> ScheduleTeachers { get; set; }
        public List<ScheduleTypeLessonViewModel> ScheduleTypeLessons { get; set; }
    }
}