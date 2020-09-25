using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace EStudy.Domain.Models
{
    public class Lesson
    {
        [Key]
        public long Id { get; set; }
        [Required, MinLength(3), MaxLength(100)]
        public string Theme { get; set; }
        [Required, MinLength(1), MaxLength(1000)]
        public string Text { get; set; }
        [Required]
        public DateTime DateLesson { get; set; }
        [Required]
        public int AssignedToTeacherId { get; set; }
        public int? TeacherConductedId { get; set; }
        [Required]
        public bool IsHindFromStudent { get; set; } = false;
        [Required]
        public bool IsReplacement { get; set; } = false;
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
        public List<Task> Tasks { get; set; }
        public List<Mark> Marks { get; set; }





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
}