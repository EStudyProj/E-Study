using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace EStudy.Application.ViewModels.Schedule.ScheduleTeacher
{
    public class ScheduleTeacherEditModel
    {
        [Key]
        [DisplayName("ID")]
        public int Id { get; set; }
        [Required, MinLength(5), MaxLength(100)]
        [DisplayName("Повне ім'я викладача")]
        public string Name { get; set; }
        [MinLength(5), MaxLength(100)]
        [DisplayName("Повне ім'я викладача (англ)")]
        public string NameEng { get; set; }
    }
}