﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace EStudy.Application.ViewModels.Schedule.ScheduleGroup
{
    public class ScheduleGroupCreateModel
    {
        [Required(ErrorMessage = "ID групи обов'язковий")]
        [DisplayName("ID групи")]
        public int GroupId { get; set; }
        [Required(ErrorMessage = "Назва обов'язкова"), MinLength(2), MaxLength(10)]
        [DisplayName("Назва групи *")]
        public string Name { get; set; }
        [MinLength(2), MaxLength(10)]
        [DisplayName("Назва групи (англ)")]
        public string NameEng { get; set; }
    }
}