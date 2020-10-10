using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace EStudy.Application.ViewModels.Schedule
{
    public class ScheduleCreateModel
    {
        [DisplayName("Група")]
        public int ScheduleGroupId { get; set; }
        [DisplayName("Аудиторія")]
        public int ScheduleAudienceId { get; set; }
        [DisplayName("Дисципліна")]
        public int ScheduleDisciplineId { get; set; }
        [DisplayName("Викладач")]
        public int ScheduleTeacherId { get; set; }
        [DisplayName("Пара")]
        public int ScheduleLessonId { get; set; }
        [DisplayName("Тип пари")]
        public int ScheduleTypeLessonId { get; set; }
        [DisplayName("День тижня")]
        public int ScheduleDayOfWeekId { get; set; }
        [DisplayName("Парність тижня")]
        public int ScheduleParityOfWeekId { get; set; }
        [Required]
        [DisplayName("Дата пари")]
        [DataType(DataType.Date)]
        public DateTime DateLesson { get; set; }
        [Required]
        [DisplayName("Заміна")]
        public bool IsReplacement { get; set; }
    }
}