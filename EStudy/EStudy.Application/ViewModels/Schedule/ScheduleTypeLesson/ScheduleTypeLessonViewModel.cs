using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
namespace EStudy.Application.ViewModels.Schedule.ScheduleTypeLesson
{
    public class ScheduleTypeLessonViewModel
    {
        [DisplayName("ID")]
        public int Id { get; set; }
        [DisplayName("Назва типу пар")]
        public string TypeName { get; set; }
        [DisplayName("Скорочена назва типу пар")]
        public string ShortTypeName { get; set; }
        [DisplayName("Назва типу пар (англ)")]
        public string TypeNameEng { get; set; }
        [DisplayName("Скорочена назва типу пар (англ)")]
        public string ShortTypeNameEng { get; set; }
        [DisplayName("Cтворено")]
        public DateTime CreatedAt { get; set; }
        [DisplayName("Останій раз відредаговано")]
        public DateTime? LastEdited { get; set; }
    }
}