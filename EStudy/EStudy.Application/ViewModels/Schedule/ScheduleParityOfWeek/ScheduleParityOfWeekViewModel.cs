using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
namespace EStudy.Application.ViewModels.Schedule.ScheduleParityOfWeek
{
    public class ScheduleParityOfWeekViewModel
    {
        [DisplayName("ID")]
        public int Id { get; set; }
        [DisplayName("Парність тижня")]
        public string Week { get; set; }
        [DisplayName("Парність тижня (англ)")]
        public string WeekEng { get; set; }
        [DisplayName("Створено")]
        public DateTime CreatedAt { get; set; }
        [DisplayName("Останій раз відредаговано")]
        public DateTime? LastEdited { get; set; }
    }
}