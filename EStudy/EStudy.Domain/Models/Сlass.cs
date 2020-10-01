using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EStudy.Domain.Models
{
    public class Сlass//Пара
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int NumOfClass { get; set; }//номер пары
        [Required]
        public DateTime TimeOfStart { get; set; }
        [Required]
        public DateTime TimeOfEnd { get; set; }



    }
}
