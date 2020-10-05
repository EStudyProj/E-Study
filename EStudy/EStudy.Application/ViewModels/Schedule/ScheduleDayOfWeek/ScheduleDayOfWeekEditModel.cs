using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace EStudy.Application.ViewModels.Schedule.ScheduleDayOfWeek
{
    public class ScheduleDayOfWeekEditModel
    {
        [Required]
        public int Id { get; set; }
        [Required, MinLength(3), MaxLength(25)]
        public string Day { get; set; }
        [MinLength(3), MaxLength(25)]
        public string DayEng { get; set; }
    }
}