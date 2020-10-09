using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace EStudy.Application.ViewModels.Schedule.ScheduleDayOfWeek
{
    public class ScheduleDayOfWeekCreateModel
    {
        [Required(ErrorMessage = "Назва обов'язкова"), MinLength(3), MaxLength(25)]
        [DisplayName("Назва дня тижня *")]
        public string Day { get; set; }
        [MinLength(3), MaxLength(25)]
        [DisplayName("Назва дня тижня (англ)")]
        public string DayEng { get; set; }
    }
}