using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
namespace EStudy.Application.ViewModels.Schedule.ScheduleDayOfWeek
{
    public class ScheduleDayOfWeekViewModel
    {
        public int Id { get; set; }
        [DisplayName("Створено")]
        public DateTime CreatedAt { get; set; }
        [DisplayName("Назва дня тижня")]
        public string Day { get; set; }
        [DisplayName("Назва дня тижня (англ)")]
        public string DayEng { get; set; }
        [DisplayName("Останій час редагування")]
        public DateTime? LastEdited { get; set; }
    }
}