using System;
using System.Collections.Generic;
using System.Text;
namespace EStudy.Application.ViewModels.Schedule
{
    public class ScheduleViewModel
    {
        public long Id { get; set; }
        public bool IsReplacement { get; set; }
        public int? TeacherId { get; set; }
        public DateTime DateLesson { get; set; }
        public string Day { get; set; }
        public string DayEng { get; set; }
        public string ParityWeek { get; set; }
        public string ParityWeekEng { get; set; }
        public byte Number { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string GroupName { get; set; }
        public string GroupNameEng { get; set; }
        public string TeacherName { get; set; }
        public string TeacherNameEng { get; set; }
        public string DisciplineName { get; set; }
        public string ShortDisciplineName { get; set; }
        public string DisciplineNameEng { get; set; }
        public string ShortDisciplineNameEng { get; set; }
        public string LessonTypeName { get; set; }
        public string LessonShortTypeName { get; set; }
        public string LessonTypeNameEng { get; set; }
        public string LessonShortTypeNameEng { get; set; }
        public string NameAudience { get; set; }
        public string NameAudienceEng { get; set; }
        public string NumberSeats { get; set; }
    }
}