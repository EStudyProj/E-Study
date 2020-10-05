using System;
using System.Collections.Generic;
using System.Text;
namespace EStudy.Application.ViewModels.Schedule.ScheduleGroup
{
    class ScheduleGroupViewModel
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public int GroupId { get; set; }
        public string Name { get; set; }
        public DateTime? LastEdited { get; set; }
    }
}