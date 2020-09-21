using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace EStudy.Domain.Models
{
    public class Group
    {
        [Key]
        public int Id { get; set; }
        [Required, MinLength(2), MaxLength(20)]
        public string GroupName { get; set; }
        [Required]
        public byte IndexItemToChanged { get; set; }
        [Required]
        public bool Released { get; set; } = false;
        [Required, MinLength(5), MaxLength(7)]
        public string CodeForConnect { get; set; }
        [MinLength(5), MaxLength(500)]
        public string AdditionalInfo { get; set; }
        [MinLength(7), MaxLength(100)]
        public string EmailByGroup { get; set; }
        [MinLength(7), MaxLength(100)]
        public string LoginToEmail { get; set; }
        [MinLength(4), MaxLength(150)]
        public string PasswordToEmail { get; set; }
        [Required]
        public bool IsShowEmail { get; set; } = true;
        public int? ClassHeadId { get; set; }
        public int SpecialtyId { get; set; }
        public Specialty Specialty { get; set; }
        public List<User> Students { get; set; }





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