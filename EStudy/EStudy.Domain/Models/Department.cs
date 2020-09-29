using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace EStudy.Domain.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        [Required, MinLength(4), MaxLength(60)]
        public string Name { get; set; }
        [MinLength(4), MaxLength(60)]
        public string InstituteName { get; set; }
        [Required, MinLength(2), MaxLength(100)]
        public string Shifr { get; set; }
        [Required]
        public int HeadById { get; set; }
        [Required, Phone]
        public string Phone { get; set; }
        [MinLength(15), MaxLength(3000)]
        public string ContactInformation { get; set; }
        [Required, MinLength(10), MaxLength(300)]
        public string Description { get; set; }
        public int IHEId { get; set; }
        public IHE IHE { get; set; }
        public List<Specialty> Specialties { get; set; }





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