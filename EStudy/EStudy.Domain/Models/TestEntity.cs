using Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace EStudy.Domain.Models
{
    public class TestEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime Date { get; set; } = DateTime.Now;
        [Required, MaxLength(20)]
        public string Code { get; set; } = Generator.GetUniqCodeUpper();
        [Required]
        public string Guid { get; set; }
    }
}