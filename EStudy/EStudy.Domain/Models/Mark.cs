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
        [Required]
        public int Value { get; set; }
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
        public long? TaskId { get; set; }
        public Task Task { get; set; }



        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        [Required, MinLength(3), MaxLength(30)]
        public string CreatedFromIPAddress { get; set; }
        [Required]
        public int CreatedByUserId { get; set; }
        [Required]
        public bool IsEdit { get; set; } = false;
        public DateTime? DateLastEdit { get; set; }
        [MinLength(3), MaxLength(30)]
        public string EditedFromIPAddress { get; set; }
        public int? LastEditedByUserId { get; set; }
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