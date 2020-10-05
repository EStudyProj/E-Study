using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace EStudy.Application.ViewModels.Schedule
{
    public class ScheduleCreateModel
    {
        [Required]
        public bool IsReplacement { get; set; }
        public int? TeacherId { get; set; }
        [Required]
        public DateTime DateLesson { get; set; }
        public int ScheduleDayOfWeekId { get; set; }
        public int ScheduleParityOfWeekId { get; set; }
        public int ScheduleLessonId { get; set; }
        public int ScheduleGroupId { get; set; }
        public int ScheduleDisciplineId { get; set; }
        public int ScheduleTypeLessonId { get; set; }
        public int ScheduleAudienceId { get; set; }
    }
}