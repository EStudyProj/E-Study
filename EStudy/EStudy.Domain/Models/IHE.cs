using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace EStudy.Domain.Models
{
    public class IHE
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        [Required, MinLength(3), MaxLength(30)]
        public string CreatedFromIPAddress { get; set; }
        [Required]
        public int CreatedById { get; set; }
        [Required, MinLength(3), MaxLength(200)]
        public string Name { get; set; }
        [Required, MinLength(2), MaxLength(25)]
        public string ShortName { get; set; }
        [Required]
        public TypeIHE TypeIHE { get; set; }
        [Required, MinLength(2), MaxLength(100)]
        public string AreaIHE { get; set; } //напрям
        [Required, MinLength(1), MaxLength(75)]
        public string LevelOfAccreditation { get; set; }
        [Required]
        public double TimeStudyOfMagister { get; set; }
        [Required]
        public double TimeStudyOfBakalavr { get; set; }
        [MinLength(10), MaxLength(300)]
        public string PhotoPath { get; set; }
        [MinLength(10), MaxLength(300)]
        public string Logo25 { get; set; }
        [MinLength(10), MaxLength(300)]
        public string Logo50 { get; set; }
        [MinLength(10), MaxLength(300)]
        public string Logo100 { get; set; }
        [MinLength(10), MaxLength(300)]
        public string LogoMax { get; set; }
        [Required, MinLength(8), MaxLength(16)]
        public string TeacherCode { get; set; } = Generator.GetString(12);
        [Required, MinLength(8), MaxLength(16)]
        public string StudentCode { get; set; } = Generator.GetString(12);
        [MinLength(10), MaxLength(1000)]
        public string History { get; set; }
        public int HeadOfIheId { get; set; }
        public int? PartOfIHE { get; set; }
        [MinLength(5), MaxLength(1000)]
        public string Description { get; set; }
        [Required]
        public bool IsEdit { get; set; } = false;
        public DateTime? DateLastEdit { get; set; }
        public int? EditedByUserId { get; set; }
        [MinLength(3), MaxLength(30)]
        public string EditedFromIPAddress { get; set; }
        [MinLength(4), MaxLength(150)]
        public string AddressInfo { get; set; }
        [Required, MinLength(2), MaxLength(50)]
        public string Locality { get; set; }
        [Required]
        public string Region { get; set; }
        [MinLength(3), MaxLength(6)]
        public string PostalCode { get; set; }
        [MinLength(5), MaxLength(50)]
        public string PhoneHumanResourcesDepartment { get; set; } //Відділ кадрів
        [MinLength(5), MaxLength(50)]
        public string PhoneAccounting { get; set; } //Бухгалтерія
        [MinLength(5), MaxLength(50)]
        public string PhoneSelectionCommittee { get; set; } //Приймальна комісія
        [MinLength(5), MaxLength(50)]
        public string ReceptionOfTheDirector { get; set; } // Приймальня директора
        [MinLength(5), MaxLength(50)]
        public string PhoneLibrary { get; set; } //Телефон бібліотеки
    }

    public enum TypeIHE
    {
        University,
        Institute,
        College,
        TechnicalSchool
    }
}