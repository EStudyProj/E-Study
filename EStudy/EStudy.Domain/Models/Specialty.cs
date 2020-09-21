using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace EStudy.Domain.Models
{
    public class Specialty
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        [Required, MinLength(3), MaxLength(30)]
        public string CreatedFromIPAddress { get; set; }
        [Required]
        public int CreatedByUserId { get; set; }
        [Required, MinLength(3), MaxLength(100)]
        public string Name { get; set; }
        [Required, MinLength(2), MaxLength(20)]
        public string Shifr { get; set; }
        [Required, MinLength(2), MaxLength(6)]
        public string CodeSpec { get; set; }
        [MinLength(5), MaxLength(100)]
        public TypeDiploma Qualification { get; set; } //здобув кваліфікацію
        [MinLength(5), MaxLength(250)]
        public string EducationalProgram { get; set; } //освітня програма
        [MinLength(5), MaxLength(250)]
        public string ProfessionalQualification { get; set; } //професійна кваліфікація
        [Required]
        public bool IsEdit { get; set; } = false;
        public DateTime? DateLastEdit { get; set; }
        public int? LastEditUserId { get; set; }
        [MinLength(3), MaxLength(30)]
        public string LastEditFromIpAddress { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }

    public enum TypeDiploma
    {
        JuniorSpecialty,
        JuniorBachelor,
        BachelorsDegree,
        MastersDegree
    }
}