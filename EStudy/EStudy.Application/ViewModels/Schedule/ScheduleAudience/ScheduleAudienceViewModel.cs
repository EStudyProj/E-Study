using System;
using System.Collections.Generic;
using System.Text;
namespace EStudy.Application.ViewModels.Schedule.ScheduleAudience
{
    public class ScheduleAudienceViewModel
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string NameAudience { get; set; }
        public string NameAudienceEng { get; set; }
        public string NumberSeats { get; set; }
        public DateTime? LastEdited { get; set; }
    }
}