using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace EStudy.Domain.Models
{
    public class Task
    {
        [Key]
        public long Id { get; set; }
        [Required, MinLength(5), MaxLength(1000)]
        public string Text { get; set; }
        [Required]
        public int MaxMarkByThisTask { get; set; }
        public DateTime? DueDate { get; set; }
        public long LessonId { get; set; }
        public Lesson Lesson { get; set; }




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