﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace EStudy.Domain.Models
{
    public class ScheduleTypeLesson
    {
        [Key]
        public int Id { get; set; }
        [Required, MinLength(2), MaxLength(25)]
        public string TypeName { get; set; }
        [MinLength(1), MaxLength(5)]
        public string ShortTypeName { get; set; }
        [MinLength(2), MaxLength(25)]
        public string TypeNameEng { get; set; }
        [MinLength(1), MaxLength(5)]
        public string ShortTypeNameEng { get; set; }
        public List<Schedule> Schedules { get; set; }


        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? LastEdited { get; set; }
    }
}