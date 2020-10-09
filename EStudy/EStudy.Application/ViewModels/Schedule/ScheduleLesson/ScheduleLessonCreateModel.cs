using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace EStudy.Application.ViewModels.Schedule.ScheduleLesson
{
    public class ScheduleLessonCreateModel
    {
        [Required]
        [DisplayName("Номер пари")]
        public byte Number { get; set; }
        [Required]
        [DisplayName("Початок пари"), DataType(DataType.Time)]
        public DateTime Start { get; set; }
        [Required]
        [DisplayName("Кінець пари"), DataType(DataType.Time)]
        public DateTime End { get; set; }
    }
}