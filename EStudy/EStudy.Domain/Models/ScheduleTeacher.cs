using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace EStudy.Domain.Models
{
    public class ScheduleTeacher
    {
        [Key]
        public int Id { get; set; }
        [Required, MinLength(5), MaxLength(100)]
        public string Name { get; set; }
        [MinLength(5), MaxLength(100)]
        public string NameEng { get; set; }
        public List<Schedule> Schedules { get; set; }


        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? LastEdited { get; set; }
    }
}