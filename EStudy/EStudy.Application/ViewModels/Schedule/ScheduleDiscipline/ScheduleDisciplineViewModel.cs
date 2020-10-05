using System;
using System.Collections.Generic;
using System.Text;
namespace EStudy.Application.ViewModels.Schedule.ScheduleDiscipline
{
    public class ScheduleDisciplineViewModel
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string DisciplineName { get; set; }
        public string ShortDisciplineName { get; set; }
        public string DisciplineNameEng { get; set; }
        public string ShortDisciplineNameEng { get; set; }
        public DateTime? LastEdited { get; set; }
    }
}