using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace EStudy.Application.ViewModels.Schedule.ScheduleLesson
{
    public class ScheduleLessonEditModel
    {
        [Key]
        [DisplayName("ID")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Назва обов`язкова")]
        [DisplayName("Номер пари *")]
        public byte Number { get; set; }
        [Required(ErrorMessage = "Час обов'язковий")]
        [DisplayName("Початок пари *"), DataType(DataType.Time)]
        public DateTime Start { get; set; }
        [Required(ErrorMessage = "Час обов'язковий")]
        [DisplayName("Кінець пари *"), DataType(DataType.Time)]
        public DateTime End { get; set; }
    }
}