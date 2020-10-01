using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EStudy.Domain.Models
{
    public class ClassRoom//аудитория 
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ClassRoomName { get; set; }// Номер или название



    }
}
