using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace EStudy.Domain.Models
{
    public class Schedule
    {
        [Key]
        public long Id { get; set; }
        [Required]
        public bool IsReplacement { get; set; } = false;
        public int? TeacherId { get; set; }
        [Required]
        public DateTime DateLesson { get; set; }
        public int ScheduleDayOfWeekId { get; set; }
        public ScheduleDayOfWeek ScheduleDayOfWeek { get; set; }
        public int ScheduleParityOfWeekId { get; set; }
        public ScheduleParityOfWeek ScheduleParityOfWeek { get; set; }
        public int ScheduleTeacherId { get; set; }
        public ScheduleTeacher ScheduleTeacher { get; set; }
        public int ScheduleLessonId { get; set; }
        public ScheduleLesson ScheduleLesson { get; set; }
        public int ScheduleGroupId { get; set; }
        public ScheduleGroup ScheduleGroup { get; set; }
        public int ScheduleDisciplineId { get; set; }
        public ScheduleDiscipline ScheduleDiscipline { get; set; }
        public int ScheduleTypeLessonId { get; set; }
        public ScheduleTypeLesson ScheduleTypeLesson { get; set; }
        public int ScheduleAudienceId { get; set; }
        public ScheduleAudience ScheduleAudience { get; set; }


        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? LastEdited { get; set; }
    }
}