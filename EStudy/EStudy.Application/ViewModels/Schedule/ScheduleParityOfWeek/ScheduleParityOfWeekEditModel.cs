﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace EStudy.Application.ViewModels.Schedule.ScheduleParityOfWeek
{
    public class ScheduleParityOfWeekEditModel
    {
        [Key]
        public int Id { get; set; }
        [Required, MinLength(3), MaxLength(25)]
        public string Week { get; set; }
        [MinLength(2), MaxLength(30)]
        public string WeekEng { get; set; }
    }
}