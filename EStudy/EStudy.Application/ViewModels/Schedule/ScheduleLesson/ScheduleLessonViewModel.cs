using System;
using System.Collections.Generic;
using System.Text;
namespace EStudy.Application.ViewModels.Schedule.ScheduleLesson
{
    public class ScheduleLessonViewModel
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public byte Number { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public DateTime? LastEdited { get; set; }
    }
}