using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace EStudy.Application.ViewModels.Schedule.ScheduleTeacher
{
    public class ScheduleTeacherCreateModel
    {
        [Required, MinLength(5), MaxLength(100)]
        public string Name { get; set; }
        [MinLength(5), MaxLength(100)]
        public string NameEng { get; set; }
    }
}