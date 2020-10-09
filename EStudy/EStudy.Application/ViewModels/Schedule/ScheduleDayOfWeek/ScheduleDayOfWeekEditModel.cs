using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace EStudy.Application.ViewModels.Schedule.ScheduleDayOfWeek
{
    public class ScheduleDayOfWeekEditModel
    {
        [Required]
        [DisplayName("ID")]
        public int Id { get; set; }
        [Required, MinLength(3), MaxLength(25)]
        [DisplayName("Назва дня")]
        public string Day { get; set; }
        [MinLength(3), MaxLength(25)]
        [DisplayName("Назва дня (англ)")]
        public string DayEng { get; set; }
    }
}