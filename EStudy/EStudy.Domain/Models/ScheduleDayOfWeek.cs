﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace EStudy.Domain.Models
{
    public class ScheduleDayOfWeek
    {
        [Key]
        public int Id { get; set; }
        [Required, MinLength(3), MaxLength(25)]
        public string Day { get; set; }
        [MinLength(3), MaxLength(25)]
        public string DayEng { get; set; }
        public List<Schedule> Schedules { get; set; }


        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? LastEdited { get; set; }
    }
}