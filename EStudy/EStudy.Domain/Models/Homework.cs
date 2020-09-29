using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace EStudy.Domain.Models
{
    public class Homework
    {
        [Key]
        public long Id { get; set; }
        [Required]
        public bool IsComplate { get; set; } = false;
        public int? ComplateByStudentId { get; set; }
        [MinLength(5), MaxLength(5000)]
        public string Text { get; set; }
        public int TeacherSetId { get; set; }
        public long TaskId { get; set; }
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
}