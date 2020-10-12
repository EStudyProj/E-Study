using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace EStudy.Application.ViewModels.Department
{
    public class DepartmentEditModel : EditModel
    {
        [Key]
        public int Id { get; set; }
        [Required, MinLength(4), MaxLength(60)]
        public string Name { get; set; }
        [MinLength(4), MaxLength(60)]
        public string InstituteName { get; set; }
        [Required, MinLength(2), MaxLength(100)]
        public string Shifr { get; set; }
        [Required, Phone]
        public string Phone { get; set; }
        [MinLength(15), MaxLength(3000)]
        public string ContactInformation { get; set; }
        [Required, MinLength(10), MaxLength(300)]
        public string Description { get; set; }
    }
}