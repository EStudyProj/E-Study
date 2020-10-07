using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace EStudy.Application.ViewModels.Schedule.ScheduleAudience
{
    public class ScheduleAudienceCreateModel
    {
        [Required, MinLength(1), MaxLength(25)]
        public string NameAudience { get; set; }
        [MinLength(1), MaxLength(25)]
        public string NameAudienceEng { get; set; }
        [MinLength(1), MaxLength(5)]
        public string NumberSeats { get; set; }
    }
}