using System;
using System.Collections.Generic;
using System.Text;
namespace EStudy.Application.ViewModels.Schedule.ScheduleDayOfWeek
{
    public class ScheduleDayOfWeekViewModel
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Day { get; set; }
        public string DayEng { get; set; }
        public DateTime? LastEdited { get; set; }
    }
}