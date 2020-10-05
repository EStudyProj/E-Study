using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace EStudy.Domain.Models
{
    public class ScheduleLesson
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public byte Number { get; set; }
        [Required]
        public DateTime Start { get; set; }
        [Required]
        public DateTime End { get; set; }
        public List<Schedule> Schedules { get; set; }


        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? LastEdited { get; set; }
    }
}