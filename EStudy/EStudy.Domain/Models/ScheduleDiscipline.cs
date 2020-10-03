using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace EStudy.Domain.Models
{
    public class ScheduleDiscipline
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
        public List<Schedule> Schedules { get; set; }
    }
}