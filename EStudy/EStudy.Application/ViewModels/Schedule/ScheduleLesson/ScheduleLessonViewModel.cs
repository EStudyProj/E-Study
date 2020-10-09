using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace EStudy.Application.ViewModels.Schedule.ScheduleLesson
{
    public class ScheduleLessonViewModel
    {
        [DisplayName("ID")]
        public int Id { get; set; }
        [DisplayName("Номер пари")]
        public byte Number { get; set; }
        [DisplayName("Початок пари"), DataType(DataType.Time)]
        public DateTime Start { get; set; }
        [DisplayName("Кінець пари"), DataType(DataType.Time)]
        public DateTime End { get; set; }
        [DisplayName("Створено")]
        public DateTime CreatedAt { get; set; }
        [DisplayName("Останій раз відредаговано")]
        public DateTime? LastEdited { get; set; }
    }
}