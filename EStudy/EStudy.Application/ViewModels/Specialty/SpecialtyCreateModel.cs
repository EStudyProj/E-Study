using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace EStudy.Application.ViewModels.Specialty
{
    public class SpecialtyCreateModel : EditModel
    {
        [Required, MinLength(3), MaxLength(100)]
        public string Name { get; set; }
        [Required, MinLength(2), MaxLength(20)]
        public string Shifr { get; set; }
        [Required, MinLength(2), MaxLength(6)]
        public string CodeSpec { get; set; }
        [Required]
        public int DepartmentId { get; set; }
    }
}