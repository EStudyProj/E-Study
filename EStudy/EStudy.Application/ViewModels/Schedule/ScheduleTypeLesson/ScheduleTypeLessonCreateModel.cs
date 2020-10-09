using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace EStudy.Application.ViewModels.Schedule.ScheduleTypeLesson
{
    public class ScheduleTypeLessonCreateModel
    {
        [Required, MinLength(2), MaxLength(25)]
        [DisplayName("Назва типу пар")]
        public string TypeName { get; set; }
        [MinLength(1), MaxLength(5)]
        [DisplayName("Скорочена назва типу пар")]
        public string ShortTypeName { get; set; }
        [MinLength(2), MaxLength(25)]
        [DisplayName("Назва типу пар (англ)")]
        public string TypeNameEng { get; set; }
        [MinLength(1), MaxLength(5)]
        [DisplayName("Скорочена назва типу пар (англ)")]
        public string ShortTypeNameEng { get; set; }
    }
}