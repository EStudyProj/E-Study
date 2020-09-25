using Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace EStudy.Domain.Models
{
    public class Diploma
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public TypeDiploma TypeDiploma { get; set; }
        [MinLength(1), MaxLength(7)]
        public string SeriesDiploma { get; set; }
        [MinLength(3), MaxLength(10)]
        public string NumberDiploma { get; set; }
        public DateTime? PresentedAt { get; set; } // дата вручання диплому
        [Required, MinLength(2), MaxLength(50)]
        public string Firstname { get; set; }
        [Required, MinLength(3), MaxLength(50)]
        public string Patronymic { get; set; }
        [Required, MinLength(2), MaxLength(50)]
        public string Lastname { get; set; }
        [Required, MinLength(3), MaxLength(200)]
        public string IHEFullName { get; set; }
        [Required, MinLength(3), MaxLength(100)]
        public string Specialty { get; set; }
        [Required, MinLength(5), MaxLength(150)]
        public string EducationalProgram { get; set; }
        [Required, MinLength(5), MaxLength(150)]
        public string ProfessionalQualification { get; set; }
        [Required, MinLength(2), MaxLength(100)]
        public string NameOfRector { get; set; }
        [MinLength(20), MaxLength(250)]
        public string PathToPrinting { get; set; }
        [MinLength(20), MaxLength(250)]
        public string PathToSignature { get; set; }
        [Required]
        public bool IsRed { get; set; } = false;
        [Required]
        public bool InPass { get; set; } = false;
        [Required, MinLength(15), MaxLength(25)]
        public string UniqCode { get; set; } = Generator.GetUniqCodeUpper();
        public int UserId { get; set; }
        public User User { get; set; }




        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        [Required, MinLength(3), MaxLength(30)]
        public string CreatedFromIPAddress { get; set; }
        [Required]
        public int CreatedByUserId { get; set; }
        [Required]
        public bool IsEdit { get; set; } = false;
        public DateTime? DateLastEdit { get; set; }
        [MinLength(3), MaxLength(30)]
        public string EditedFromIPAddress { get; set; }
        public int? LastEditedByUserId { get; set; }
    }
}