using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EStudy.Domain.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string CourseName { get; set; }
    }
}
