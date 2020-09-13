using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace EStudy.Domain.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        [Required, MinLength(2), MaxLength(50)]
        public string Firstname { get; set; }
    }
}