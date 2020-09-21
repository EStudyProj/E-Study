using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace EStudy.Application.ViewModels.Department
{
    public class DepartmentCreateModel : EditModel
    {
        [Required, MinLength(4), MaxLength(24)]
        public string Name { get; set; }
        [Required, MinLength(2), MaxLength(100)]
        public string Shifr { get; set; }
        [Required]
        public int HeadById { get; set; }
        [Required, Phone]
        public string Phone { get; set; }
        [Required, MinLength(10), MaxLength(300)]
        public string Description { get; set; }
        public int IHEId { get; set; }
    }
}