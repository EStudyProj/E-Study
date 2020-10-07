using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace EStudy.Application.ViewModels.Schedule.ScheduleAudience
{
    public class ScheduleAudienceEditModel
    {
        [Required]
        public int Id { get; set; }
        [Required, MinLength(1), MaxLength(25)]
        [DisplayName("Назва аудиторії")]
        public string NameAudience { get; set; }
        [MinLength(1), MaxLength(25)]
        [DisplayName("Назва аудиторії (англ.)")]
        public string NameAudienceEng { get; set; }
        [MinLength(1), MaxLength(5)]
        [DisplayName("Кількість місць")]
        public string NumberSeats { get; set; }
    }
}