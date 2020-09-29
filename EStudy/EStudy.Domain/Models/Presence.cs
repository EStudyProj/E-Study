using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace EStudy.Domain.Models
{
    public class Presence
    {
        [Key]
        public long Id { get; set; }
        [Required]
        public int StudentId { get; set; }
        [Required]
        public PresentsType Presents { get; set; }
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

    public enum PresentsType
    {
        Exist,
        Absent
    }
}