using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace EStudy.Domain.Models
{
    public class ScheduleAudience
    {
        [Key]
        public int Id { get; set; }
        [Required, MinLength(1), MaxLength(25)]
        public string NameAudience { get; set; }
        [MinLength(1), MaxLength(25)]
        public string NameAudienceEng { get; set; }
        public string NumberSeats { get; set; }
        public List<Schedule> Schedules { get; set; }


        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? LastEdited { get; set; }
    }
}