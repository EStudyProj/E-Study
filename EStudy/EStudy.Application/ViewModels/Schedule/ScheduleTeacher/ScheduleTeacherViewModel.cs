using System;
using System.Collections.Generic;
using System.Text;
namespace EStudy.Application.ViewModels.Schedule.ScheduleTeacher
{
    public class ScheduleTeacherViewModel
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Name { get; set; }
        public string NameEng { get; set; }
        public DateTime? LastEdited { get; set; }
    }
}