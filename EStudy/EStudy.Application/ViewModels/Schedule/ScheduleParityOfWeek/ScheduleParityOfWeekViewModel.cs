using System;
using System.Collections.Generic;
using System.Text;
namespace EStudy.Application.ViewModels.Schedule.ScheduleParityOfWeek
{
    public class ScheduleParityOfWeekViewModel
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Week { get; set; }
        public string WeekEng { get; set; }
        public DateTime? LastEdited { get; set; }
    }
}