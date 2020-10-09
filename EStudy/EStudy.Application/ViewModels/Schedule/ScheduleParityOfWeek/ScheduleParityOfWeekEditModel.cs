using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace EStudy.Application.ViewModels.Schedule.ScheduleParityOfWeek
{
    public class ScheduleParityOfWeekEditModel
    {
        [Key]
        [DisplayName("ID")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Парність обо'язкова"), MinLength(3), MaxLength(25)]
        [DisplayName("Парність тижня *")]
        public string Week { get; set; }
        [MinLength(2), MaxLength(30)]
        [DisplayName("Парність тижня (англ)")]
        public string WeekEng { get; set; }
    }
}