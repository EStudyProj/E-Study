﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace EStudy.Application.ViewModels.Schedule.ScheduleDiscipline
{
    public class ScheduleDisciplineEditModel
    {
        [Key]
        [DisplayName("ID")]
        public int Id { get; set; }
        [Required, MinLength(3), MaxLength(100)]
        [DisplayName("Назва дисципліни")]
        public string DisciplineName { get; set; }
        [MinLength(1), MaxLength(5)]
        [DisplayName("Коротка назва дисципліни")]
        public string ShortDisciplineName { get; set; }
        [MinLength(3), MaxLength(100)]
        [DisplayName("Назва дисципліни (англ)")]
        public string DisciplineNameEng { get; set; }
        [MinLength(1), MaxLength(5)]
        [DisplayName("Коротка назва дисципліни (англ)")]
        public string ShortDisciplineNameEng { get; set; }
    }
}