using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
namespace EStudy.Application.ViewModels.Schedule.ScheduleTeacher
{
    public class ScheduleTeacherViewModel
    {
        [DisplayName("ID")]
        public int Id { get; set; }
        [DisplayName("Повне ім'я викладача")]
        public string Name { get; set; }
        [DisplayName("Повне ім'я викладача (англ)")]
        public string NameEng { get; set; }
        [DisplayName("Створено")]
        public DateTime CreatedAt { get; set; }
        [DisplayName("Останій раз відредаговано")]
        public DateTime? LastEdited { get; set; }
    }
}