using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
namespace EStudy.Application.ViewModels.Schedule.ScheduleAudience
{
    public class ScheduleAudienceViewModel
    {
        [DisplayName("ID")]
        public int Id { get; set; }
        [DisplayName("Створено")]
        public DateTime CreatedAt { get; set; }
        [DisplayName("Назва аудиторії")]
        public string NameAudience { get; set; }
        [DisplayName("Назва аудиторії (англ.)")]
        public string NameAudienceEng { get; set; }
        [DisplayName("Кількість місць")]
        public string NumberSeats { get; set; }
        [DisplayName("Останій раз відредаговано")]
        public DateTime? LastEdited { get; set; }
    }
}