using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace EStudy.Domain.Models
{
    public class Mark
    {
        [Key]
        public long Id { get; set; }
        [Required, MinLength(1), MaxLength(3)]
        public string Value { get; set; } // n - not exist, e - exist on lesson, 1-12 mark value
        [MinLength(3), MaxLength(75)]
        public string Description { get; set; }
        [Required]
        public TypeMark TypeMark { get; set; }
        [Required]
        public int TeacherSetId { get; set; }
        [Required]
        public bool IsHindFromStudents { get; set; } = false;
        public long? LessonId { get; set; }
        public Lesson Lesson { get; set; }
    }

    public enum TypeMark
    {
        Regular,
        Homework,
        Lecture,
        Practice,
        Laboratory,
        Exam
    }
}