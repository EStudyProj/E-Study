using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace EStudy.Application.ViewModels.Schedule.ScheduleDiscipline
{
    public class ScheduleDisciplineEditModel
    {
        [Key]
        public int Id { get; set; }
        [Required, MinLength(3), MaxLength(100)]
        public string DisciplineName { get; set; }
        [MinLength(1), MaxLength(5)]
        public string ShortDisciplineName { get; set; }
        [MinLength(3), MaxLength(100)]
        public string DisciplineNameEng { get; set; }
        [MinLength(1), MaxLength(5)]
        public string ShortDisciplineNameEng { get; set; }
    }
}