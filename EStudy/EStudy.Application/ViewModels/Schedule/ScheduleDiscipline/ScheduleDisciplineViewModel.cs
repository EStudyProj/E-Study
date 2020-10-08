using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
namespace EStudy.Application.ViewModels.Schedule.ScheduleDiscipline
{
    public class ScheduleDisciplineViewModel
    {
        public int Id { get; set; }
        [DisplayName("Створено")]
        public DateTime CreatedAt { get; set; }
        [DisplayName("Назва дисципліни")]
        public string DisciplineName { get; set; }
        [DisplayName("Коротка назва дисципліни")]
        public string ShortDisciplineName { get; set; }
        [DisplayName("Назва дисципліни (англ)")]
        public string DisciplineNameEng { get; set; }
        [DisplayName("Коротка назва дисципліни (англ)")]
        public string ShortDisciplineNameEng { get; set; }
        [DisplayName("Останій час редагування")]
        public DateTime? LastEdited { get; set; }
    }
}