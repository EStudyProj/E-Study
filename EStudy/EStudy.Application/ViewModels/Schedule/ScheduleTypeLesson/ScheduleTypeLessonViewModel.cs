using System;
using System.Collections.Generic;
using System.Text;
namespace EStudy.Application.ViewModels.Schedule.ScheduleTypeLesson
{
    public class ScheduleTypeLessonViewModel
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string TypeName { get; set; }
        public string ShortTypeName { get; set; }
        public string TypeNameEng { get; set; }
        public string ShortTypeNameEng { get; set; }
        public DateTime? LastEdited { get; set; }
    }
}