using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace EStudy.Application.ViewModels.Schedule.ScheduleLesson
{
    public class ScheduleLessonEditModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public byte Number { get; set; }
        [Required]
        public DateTime Start { get; set; }
        [Required]
        public DateTime End { get; set; }
    }
}