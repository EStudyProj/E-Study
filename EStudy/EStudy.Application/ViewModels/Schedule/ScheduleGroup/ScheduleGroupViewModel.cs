using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
namespace EStudy.Application.ViewModels.Schedule.ScheduleGroup
{
    public class ScheduleGroupViewModel
    {
        [DisplayName("ID")]
        public int Id { get; set; }
        [DisplayName("ID групи")]
        public int GroupId { get; set; }
        [DisplayName("Назва групи")]
        public string Name { get; set; }
        [DisplayName("Назва групи (англ)")]
        public string NameEng { get; set; }
        [DisplayName("Створено")]
        public DateTime CreatedAt { get; set; }
        [DisplayName("Останій раз відредаговано")]
        public DateTime? LastEdited { get; set; }
    }
}