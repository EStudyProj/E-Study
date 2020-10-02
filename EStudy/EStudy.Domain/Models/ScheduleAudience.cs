using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace EStudy.Domain.Models
{
    public class ScheduleAudience
    {
        [Key]
        public int Id { get; set; }
        [Required, MinLength(1), MaxLength(25)]
        public string NameAudience { get; set; }
        [MinLength(1), MaxLength(25)]
        public string NameAudienceEng { get; set; }
    }
}