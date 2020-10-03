﻿using EStudy.Application.ViewModels.Schedule;
using EStudy.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace EStudy.Application
{
    public static class Mapper
    {
        public static ScheduleViewModel GetSchedule(Schedule model)
        {
            if (model == null) return null;
            return new ScheduleViewModel
            {
                Id = model.Id,
                IsReplacement = model.IsReplacement,
                TeacherId = model.TeacherId,
                DateLesson = model.DateLesson,
                Day = model.ScheduleDayOfWeek.Day,
                DayEng = model.ScheduleDayOfWeek.DayEng,
                ParityWeek = model.ScheduleParityOfWeek.Week,
                Number = model.ScheduleLesson.Number,
                Start = model.ScheduleLesson.Start,
                End = model.ScheduleLesson.End,
                GroupName = model.ScheduleGroup.Name,
                DisciplineName = model.ScheduleDiscipline.DisciplineName,
                ShortDisciplineName = model.ScheduleDiscipline.ShortDisciplineName,
                DisciplineNameEng = model.ScheduleDiscipline.DisciplineNameEng,
                LessonTypeName = model.ScheduleTypeLesson.TypeName,
                LessonShortTypeName = model.ScheduleTypeLesson.ShortTypeName,
                LessonTypeNameEng = model.ScheduleTypeLesson.TypeNameEng,
                LessonShortTypeNameEng = model.ScheduleTypeLesson.ShortTypeNameEng,
                NameAudience = model.ScheduleAudience.NameAudience,
                NameAudienceEng = model.ScheduleAudience.NameAudienceEng
            };
        }

        public static List<ScheduleViewModel> GetSchedules(List<Schedule> models)
        {
            if (models == null || models.Count == 0) return null;
            return models.Select(model => new ScheduleViewModel
            {
                Id = model.Id,
                IsReplacement = model.IsReplacement,
                TeacherId = model.TeacherId,
                DateLesson = model.DateLesson,
                Day = model.ScheduleDayOfWeek.Day,
                DayEng = model.ScheduleDayOfWeek.DayEng,
                ParityWeek = model.ScheduleParityOfWeek.Week,
                Number = model.ScheduleLesson.Number,
                Start = model.ScheduleLesson.Start,
                End = model.ScheduleLesson.End,
                GroupName = model.ScheduleGroup.Name,
                DisciplineName = model.ScheduleDiscipline.DisciplineName,
                ShortDisciplineName = model.ScheduleDiscipline.ShortDisciplineName,
                DisciplineNameEng = model.ScheduleDiscipline.DisciplineNameEng,
                LessonTypeName = model.ScheduleTypeLesson.TypeName,
                LessonShortTypeName = model.ScheduleTypeLesson.ShortTypeName,
                LessonTypeNameEng = model.ScheduleTypeLesson.TypeNameEng,
                LessonShortTypeNameEng = model.ScheduleTypeLesson.ShortTypeNameEng,
                NameAudience = model.ScheduleAudience.NameAudience,
                NameAudienceEng = model.ScheduleAudience.NameAudienceEng
            }).ToList();
        }
    }
}