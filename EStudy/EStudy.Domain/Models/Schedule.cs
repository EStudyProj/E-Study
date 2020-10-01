using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EStudy.Domain.Models
{
    public class Schedule
    {
        [Key]
        public int Id { get; set; }
        public string DayOfWeek { get; set; }
        public int ClassId { get; set; }
        public Сlass Class { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public int TypeOfClassId { get; set; }
        public TypeOfClass TypeOfClass { get; set; }
        public int ClassRoomId { get; set; }
        public ClassRoom ClassRoom { get; set; }
    }
}
