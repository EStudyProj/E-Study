using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace EStudy.Application.ViewModels.Schedule.ScheduleTypeLesson
{
    public class ScheduleTypeLessonEditModel
    {
        [Key]
        public int Id { get; set; }
        [Required, MinLength(2), MaxLength(25)]
        public string TypeName { get; set; }
        [MinLength(1), MaxLength(5)]
        public string ShortTypeName { get; set; }
        [MinLength(2), MaxLength(25)]
        public string TypeNameEng { get; set; }
        [MinLength(1), MaxLength(5)]
        public string ShortTypeNameEng { get; set; }
    }
}