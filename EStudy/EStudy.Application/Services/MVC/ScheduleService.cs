﻿using AutoMapper;
using EStudy.Application.Interfaces.MVC;
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
                NameAudienceEng = model.NameAudienceEng,
                NumberSeats = model.NumberSeats
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
                Name = model.Name,
                NameEng = model.NameEng
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

        public async Task<string> AddScheduleTeacher(ScheduleTeacherCreateModel model)
        {
            return await uniOfWork.ScheduleTeachers.CreateAsync(new ScheduleTeacher
            {
                Name = model.Name,
                NameEng = model.NameEng
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
                DateLesson = model.DateLesson,
                ScheduleDayOfWeekId = model.ScheduleDayOfWeekId,
                ScheduleParityOfWeekId = model.ScheduleParityOfWeekId,
                ScheduleLessonId = model.ScheduleLessonId,
                ScheduleGroupId = model.ScheduleGroupId,
                ScheduleDisciplineId = model.ScheduleDisciplineId,
                ScheduleTypeLessonId = model.ScheduleTypeLessonId,
                ScheduleAudienceId = model.ScheduleAudienceId,
                ScheduleTeacherId = model.ScheduleTeacherId
            });
        }

        public async System.Threading.Tasks.Task CreateTestData()
        {
            await uniOfWork.ScheduleAudiences.CreateRangeAsync(new List<ScheduleAudience>
            {
                new ScheduleAudience { NameAudience = "Актовий зал", NameAudienceEng = "", NumberSeats = "100" },
                new ScheduleAudience { NameAudience = "Студентський центр", NameAudienceEng = "", NumberSeats = "25" },
                new ScheduleAudience { NameAudience = "326", NameAudienceEng = "326", NumberSeats = "30" },
                new ScheduleAudience { NameAudience = "517", NameAudienceEng = "517", NumberSeats = "35" },
                new ScheduleAudience { NameAudience = "310", NameAudienceEng = "310", NumberSeats = "27" },
                new ScheduleAudience { NameAudience = "120", NameAudienceEng = "120", NumberSeats = "50" },
                new ScheduleAudience { NameAudience = "225", NameAudienceEng = "225", NumberSeats = "20" }
            });
            await uniOfWork.ScheduleDayOfWeeks.CreateRangeAsync(new List<ScheduleDayOfWeek>
            {
                new ScheduleDayOfWeek { Day = "Понеділок", DayEng = "Monday" },
                new ScheduleDayOfWeek { Day = "Вівторок", DayEng = "Thuesday" },
                new ScheduleDayOfWeek { Day = "Середа", DayEng = "Wednesday" },
                new ScheduleDayOfWeek { Day = "Четверг", DayEng = "Threthday" },
                new ScheduleDayOfWeek { Day = "П'ятниця", DayEng = "Friday" }
            });
            await uniOfWork.ScheduleDisciplines.CreateRangeAsync(new List<ScheduleDiscipline>
            {
                new ScheduleDiscipline { DisciplineName = "Об'єктно-орієнтоване програмування", DisciplineNameEng = "Object-Oriented Prog", ShortDisciplineName = "C#", ShortDisciplineNameEng = "C#" },
                new ScheduleDiscipline { DisciplineName = "Вища Математика", DisciplineNameEng = "Hight Math", ShortDisciplineName = "ВМ", ShortDisciplineNameEng = "HM" },
                new ScheduleDiscipline { DisciplineName = "Філософія", DisciplineNameEng = "Filisofy", ShortDisciplineName = "Фл", ShortDisciplineNameEng = "Fl" },
                new ScheduleDiscipline { DisciplineName = "Проектування інтерфейсу користувача", DisciplineNameEng = "User interface development", ShortDisciplineName = "ПІК", ShortDisciplineNameEng = "UID" },
                new ScheduleDiscipline { DisciplineName = "Іноземна мова", DisciplineNameEng = "English", ShortDisciplineName = "ІМ", ShortDisciplineNameEng = "Eng" },
                new ScheduleDiscipline { DisciplineName = "Web технології та Web дизайн", DisciplineNameEng = "Web tech and Web design", ShortDisciplineName = "Web", ShortDisciplineNameEng = "Web" }
            });
            await uniOfWork.ScheduleGroups.CreateRangeAsync(new List<ScheduleGroup>
            {
                new ScheduleGroup { GroupId = 1, Name = "ПД-24", NameEng = "PD-24" },
                new ScheduleGroup { GroupId = 2, Name = "ПД-23", NameEng = "PD-23" },
                new ScheduleGroup { GroupId = 3, Name = "ПД-22", NameEng = "PD-22" },
                new ScheduleGroup { GroupId = 4, Name = "ПД-21", NameEng = "PD-21" },
                new ScheduleGroup { GroupId = 5, Name = "КІД-21", NameEng = "CED-21" },
                new ScheduleGroup { GroupId = 6, Name = "КІД-22", NameEng = "CED-22" }
            });
            await uniOfWork.ScheduleLessons.CreateRangeAsync(new List<ScheduleLesson>
            {
                new ScheduleLesson { Number = 1, Start = new DateTime(2000,01,01,8,0,0), End = new DateTime(2000,01,01,9,35,0) },
                new ScheduleLesson { Number = 2, Start = new DateTime(2000,01,01,9,45,0), End = new DateTime(2000,01,01,11,20,0) },
                new ScheduleLesson { Number = 3, Start = new DateTime(2000,01,01,11,45,0), End = new DateTime(2000,01,01,13,20,0) },
                new ScheduleLesson { Number = 4, Start = new DateTime(2000,01,01,15,05,0), End = new DateTime(2000,01,01,16,50,0) },
                new ScheduleLesson { Number = 5, Start = new DateTime(2000,01,01,17,0,0), End = new DateTime(2000,01,01,18,35,0) },
                new ScheduleLesson { Number = 6, Start = new DateTime(2000,01,01,18,50,0), End = new DateTime(2000,01,01,20,20,0) }
            });
            await uniOfWork.ScheduleParityOfWeeks.CreateRangeAsync(new List<ScheduleParityOfWeek>
            {
                new ScheduleParityOfWeek { Week = "Парне", WeekEng = "" },
                new ScheduleParityOfWeek { Week = "Непарне", WeekEng = "" },
                new ScheduleParityOfWeek { Week = "Б/в", WeekEng = "" }
            });
            await uniOfWork.ScheduleTeachers.CreateRangeAsync(new List<ScheduleTeacher>
            {
                new ScheduleTeacher { Name = "Шевченко Галина Володимирівна", NameEng = "Shevchenko Galyna Volodymurivna" },
                new ScheduleTeacher { Name = "Попершняк Світлана Володимирівна", NameEng = "Popereshnyak Svitlana Volodymurivna" },
                new ScheduleTeacher { Name = "Гребенюк Віктор Вікторович", NameEng = "Grebenyk Viktor Viktorovich" },
                new ScheduleTeacher { Name = "Орендарчук Надія Василівна", NameEng = "Orendarchuk Nadiya Vasivlna" },
                new ScheduleTeacher { Name = "Бондарчук Андрій Петрович", NameEng = "Bondarchuk Adrii Petrovich" },
                new ScheduleTeacher { Name = "Яскевич Владислав Олександрович", NameEng = "Yascevich Vladyslav Olexandrovich" }
            });
            await uniOfWork.ScheduleTypeLessons.CreateRangeAsync(new List<ScheduleTypeLesson>
            {
                new ScheduleTypeLesson { ShortTypeName = "Лк", ShortTypeNameEng = "Lc", TypeName = "Лекція", TypeNameEng = "Lecture" },
                new ScheduleTypeLesson { ShortTypeName = "Сем", ShortTypeNameEng = "Sem", TypeName = "Семінар", TypeNameEng = "Seminar" },
                new ScheduleTypeLesson { ShortTypeName = "Ср", ShortTypeNameEng = "Iw", TypeName = "Самостійна робота", TypeNameEng = "Indepented work" },
                new ScheduleTypeLesson { ShortTypeName = "Рр", ShortTypeNameEng = "Cw", TypeName = "Розрахункова робота", TypeNameEng = "Class work" },
                new ScheduleTypeLesson { ShortTypeName = "Ек", ShortTypeNameEng = "Ex", TypeName = "Екзамен", TypeNameEng = "Exam" }
            });
        }

        public async Task<string> EditSchedule(ScheduleEditModel model)
        {
            var schedule = await uniOfWork.Schedules.GetByWhereAsTrackingAsync(d => d.Id == model.Id);
            if (schedule == null)
                return "Not found";
            schedule.IsReplacement = model.IsReplacement;
            schedule.DateLesson = model.DateLesson;
            schedule.ScheduleDayOfWeekId = model.ScheduleDayOfWeekId;
            schedule.ScheduleParityOfWeekId = model.ScheduleParityOfWeekId;
            schedule.ScheduleLessonId = model.ScheduleLessonId;
            schedule.ScheduleGroupId = model.ScheduleGroupId;
            schedule.ScheduleDisciplineId = model.ScheduleDisciplineId;
            schedule.ScheduleTypeLessonId = model.ScheduleTypeLessonId;
            schedule.ScheduleAudienceId = model.ScheduleAudienceId;
            schedule.ScheduleTeacherId = model.ScheduleTeacherId;
            schedule.LastEdited = DateTime.Now;
            return await uniOfWork.Schedules.EditAsync(schedule);
        }

        public async Task<string> EditScheduleAudience(ScheduleAudienceEditModel model)
        {
            var scheduleAudience = await uniOfWork.ScheduleAudiences.GetByWhereAsTrackingAsync(d => d.Id == model.Id);
            if (scheduleAudience == null)
                return "Not found";
            scheduleAudience.NameAudience = model.NameAudience;
            scheduleAudience.NameAudienceEng = model.NameAudienceEng;
            scheduleAudience.NumberSeats = model.NumberSeats;
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
            scheduleGroup.NameEng = model.NameEng;
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

        public async Task<string> EditScheduleTeacher(ScheduleTeacherEditModel model)
        {
            var schedTeacher = await uniOfWork.ScheduleTeachers.GetByWhereAsTrackingAsync(d => d.Id == model.Id);
            if (schedTeacher == null)
                return "Not found";
            schedTeacher.Name = model.Name;
            schedTeacher.NameEng = model.NameEng;
            schedTeacher.LastEdited = DateTime.Now;
            return await uniOfWork.ScheduleTeachers.EditAsync(schedTeacher);
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

        public async Task<ScheduleListEntitiesViewModel> GetAllData()
        {
            return new ScheduleListEntitiesViewModel
            {
                ScheduleAudiences = mapper.Map<List<ScheduleAudienceViewModel>>(await uniOfWork.ScheduleAudiences.GetAllAsync()),
                ScheduleDayOfWeeks = mapper.Map<List<ScheduleDayOfWeekViewModel>>(await uniOfWork.ScheduleDayOfWeeks.GetAllAsync()),
                ScheduleDisciplines = mapper.Map<List<ScheduleDisciplineViewModel>>(await uniOfWork.ScheduleDisciplines.GetAllAsync()),
                ScheduleGroups = mapper.Map<List<ScheduleGroupViewModel>>(await uniOfWork.ScheduleGroups.GetAllAsync()),
                ScheduleLessons = mapper.Map<List<ScheduleLessonViewModel>>(await uniOfWork.ScheduleLessons.GetAllAsync()),
                ScheduleParityOfWeeks = mapper.Map<List<ScheduleParityOfWeekViewModel>>(await uniOfWork.ScheduleParityOfWeeks.GetAllAsync()),
                ScheduleTeachers = mapper.Map<List<ScheduleTeacherViewModel>>(await uniOfWork.ScheduleTeachers.GetAllAsync()),
                ScheduleTypeLessons = mapper.Map<List<ScheduleTypeLessonViewModel>>(await uniOfWork.ScheduleTypeLessons.GetAllAsync())
            };
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

        public async Task<List<ScheduleTeacherViewModel>> GetAllScheduleTeachers()
        {
            return mapper.Map<List<ScheduleTeacherViewModel>>(await uniOfWork.ScheduleTeachers.GetAllAsync());
        }

        public async Task<List<ScheduleTypeLessonViewModel>> GetAllScheduleTypeLessons()
        {
            return mapper.Map<List<ScheduleTypeLessonViewModel>>(await uniOfWork.ScheduleTypeLessons.GetAllAsync());
        }

        public async Task<List<ScheduleViewModel>> GetLastAddedSchedule(int count)
        {
            return Mapper.GetSchedules(await uniOfWork.Schedules.GetLastAddedSchedules(count));
        }

        public async Task<List<ScheduleViewModel>> GetLastEditedSchedule(int count)
        {
            return Mapper.GetSchedules(await uniOfWork.Schedules.GetLastEditedSchedules(count));
        }

        public async Task<ScheduleAudienceEditModel> GetScheduleAudienceForEdit(int Id)
        {
            var audience = await uniOfWork.ScheduleAudiences.GetByWhereAsync(d => d.Id == Id);
            if (audience == null) return null;
            return new ScheduleAudienceEditModel
            {
                Id = audience.Id,
                NameAudience = audience.NameAudience,
                NameAudienceEng = audience.NameAudienceEng,
                NumberSeats = audience.NumberSeats
            };
        }

        public async Task<ScheduleViewModel> GetScheduleById(long Id)
        {
            return Mapper.GetSchedule(await uniOfWork.Schedules.GetScheduleByIdAsync(Id));
        }

        public async Task<ScheduleDayOfWeekEditModel> GetScheduleDayOfWeekForEdit(int Id)
        {
            var dayOfWeek = await uniOfWork.ScheduleDayOfWeeks.GetByWhereAsync(d => d.Id == Id);
            if (dayOfWeek == null) return null;
            return new ScheduleDayOfWeekEditModel
            {
                Id = dayOfWeek.Id,
                Day = dayOfWeek.Day,
                DayEng = dayOfWeek.DayEng
            };
        }

        public async Task<ScheduleDisciplineEditModel> GetScheduleDisciplineForEdit(int Id)
        {
            var discipline = await uniOfWork.ScheduleDisciplines.GetByWhereAsync(d => d.Id == Id);
            if (discipline == null) return null;
            return new ScheduleDisciplineEditModel
            {
                Id = discipline.Id,
                DisciplineName = discipline.DisciplineName,
                ShortDisciplineName = discipline.ShortDisciplineName,
                DisciplineNameEng = discipline.DisciplineNameEng,
                ShortDisciplineNameEng = discipline.ShortDisciplineNameEng
            };
        }

        public async Task<ScheduleEditModel> GetScheduleForEdit(long Id)
        {
            var res = await uniOfWork.Schedules.GetByWhereAsTrackingAsync(d => d.Id == Id);
            if (res == null) return null;
            return new ScheduleEditModel
            {
                Id = res.Id,
                DateLesson = res.DateLesson,
                IsReplacement = res.IsReplacement,
                ScheduleAudienceId = res.ScheduleAudienceId,
                ScheduleDayOfWeekId = res.ScheduleDayOfWeekId,
                ScheduleDisciplineId = res.ScheduleDisciplineId,
                ScheduleGroupId = res.ScheduleGroupId,
                ScheduleLessonId = res.ScheduleLessonId,
                ScheduleParityOfWeekId = res.ScheduleParityOfWeekId,
                ScheduleTeacherId = res.ScheduleTeacherId,
                ScheduleTypeLessonId = res.ScheduleTypeLessonId
            };
        }

        public async Task<ScheduleGroupEditModel> GetScheduleGroupForEdit(int Id)
        {
            var group = await uniOfWork.ScheduleGroups.GetByWhereAsync(d => d.Id == Id);
            if (group == null) return null;
            return new ScheduleGroupEditModel
            {
                Id = group.Id,
                GroupId = group.GroupId,
                Name = group.Name,
                NameEng = group.NameEng
            };
        }

        public async Task<ScheduleLessonEditModel> GetScheduleLessonForEdit(int Id)
        {
            var lesson = await uniOfWork.ScheduleLessons.GetByWhereAsync(d => d.Id == Id);
            if (lesson == null) return null;
            return new ScheduleLessonEditModel
            {
                Id = lesson.Id,
                Number = lesson.Number,
                Start = lesson.Start,
                End = lesson.End
            };
        }

        public async Task<ScheduleParityOfWeekEditModel> GetScheduleParityOfWeekForEdit(int Id)
        {
            var parityOfWeek = await uniOfWork.ScheduleParityOfWeeks.GetByWhereAsync(d => d.Id == Id);
            if (parityOfWeek == null) return null;
            return new ScheduleParityOfWeekEditModel
            {
                Id = parityOfWeek.Id,
                Week = parityOfWeek.Week,
                WeekEng = parityOfWeek.WeekEng
            };
        }

        public async Task<ScheduleTeacherEditModel> GetScheduleTeacherForEdit(int Id)
        {
            var teacher = await uniOfWork.ScheduleTeachers.GetByWhereAsync(d => d.Id == Id);
            if (teacher == null) return null;
            return new ScheduleTeacherEditModel
            {
                Id = teacher.Id,
                Name = teacher.Name,
                NameEng = teacher.NameEng
            };
        }

        public async Task<ScheduleTypeLessonEditModel> GetScheduleTypeLessonForEdit(int Id)
        {
            var typeLesson = await uniOfWork.ScheduleTypeLessons.GetByWhereAsync(d => d.Id == Id);
            if (typeLesson == null) return null;
            return new ScheduleTypeLessonEditModel
            {
                Id = typeLesson.Id,
                TypeName = typeLesson.TypeName,
                ShortTypeName = typeLesson.ShortTypeName,
                TypeNameEng = typeLesson.TypeNameEng,
                ShortTypeNameEng = typeLesson.ShortTypeNameEng
            };
        }

        public async Task<string> RemoveAllAudiences()
        {
            var audiences = await uniOfWork.ScheduleAudiences.GetAllAsTrackingAsync();
            return audiences == null || audiences.Count == 0 ? "OK" : await uniOfWork.ScheduleAudiences.RemoveRangeAsync(audiences);
        }

        public async Task<string> RemoveAllDayOfWeeks()
        {
            var days = await uniOfWork.ScheduleDayOfWeeks.GetAllAsTrackingAsync();
            return days == null || days.Count == 0 ? "OK" : await uniOfWork.ScheduleDayOfWeeks.RemoveRangeAsync(days);
        }

        public async Task<string> RemoveAllDisciplines()
        {
            var disciplines = await uniOfWork.ScheduleDisciplines.GetAllAsTrackingAsync();
            return disciplines == null || disciplines.Count == 0 ? "OK" : await uniOfWork.ScheduleDisciplines.RemoveRangeAsync(disciplines);
        }

        public async Task<string> RemoveAllGroups()
        {
            var groups = await uniOfWork.ScheduleGroups.GetAllAsTrackingAsync();
            return groups == null || groups.Count == 0 ? "OK" : await uniOfWork.ScheduleGroups.RemoveRangeAsync(groups);
        }

        public async Task<string> RemoveAllLessons()
        {
            var lessons = await uniOfWork.ScheduleLessons.GetAllAsTrackingAsync();
            return lessons == null || lessons.Count == 0 ? "OK" : await uniOfWork.ScheduleLessons.RemoveRangeAsync(lessons);
        }

        public async Task<string> RemoveAllParityOfWeeks()
        {
            var parityOfWeeks = await uniOfWork.ScheduleParityOfWeeks.GetAllAsTrackingAsync();
            return parityOfWeeks == null || parityOfWeeks.Count == 0 ? "OK" : await uniOfWork.ScheduleParityOfWeeks.RemoveRangeAsync(parityOfWeeks);
        }

        public async Task<string> RemoveAllTeachers()
        {
            var teachers = await uniOfWork.ScheduleTeachers.GetAllAsTrackingAsync();
            return teachers == null || teachers.Count == 0 ? "OK" : await uniOfWork.ScheduleTeachers.RemoveRangeAsync(teachers);
        }

        public async Task<string> RemoveAllTypeLessons()
        {
            var typeLessons = await uniOfWork.ScheduleTypeLessons.GetAllAsTrackingAsync();
            return typeLessons == null || typeLessons.Count == 0 ? "OK" : await uniOfWork.ScheduleTypeLessons.RemoveRangeAsync(typeLessons);
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

        public async Task<string> RemoveScheduleTeacher(int Id)
        {
            var schedTeacher = await uniOfWork.ScheduleTeachers.GetByWhereAsTrackingAsync(d => d.Id == Id);
            if (schedTeacher == null)
                return "Not found";
            return await uniOfWork.ScheduleTeachers.RemoveAsync(schedTeacher);
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