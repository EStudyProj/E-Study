using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace EStudy.Application.ViewModels.Schedule.ScheduleGroup
{
    public class ScheduleGroupEditModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int GroupId { get; set; }
        [Required, MinLength(2), MaxLength(10)]
        public string Name { get; set; }
    }
}