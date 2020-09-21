using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace EStudy.Domain.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required, MinLength(2), MaxLength(50)]
        public string Firstname { get; set; }
        [Required, MinLength(3), MaxLength(50)]
        public string Patronymic { get; set; }
        [Required, MinLength(2), MaxLength(50)]
        public string Lastname { get; set; }
        public DateTime? Born { get; set; }
        [MinLength(1), MaxLength(300)]
        public string Description { get; set; }
        [Required, MinLength(4), MaxLength(35)]
        public string Username { get; set; }
        [MinLength(5), MaxLength(30)]
        public string Phone { get; set; }
        public bool IsShowPhone { get; set; } = true;
        [MinLength(7), MaxLength(100)]
        public string Email { get; set; }
        public bool IsShowEmail { get; set; } = true;
        [MinLength(10), MaxLength(300)]
        public string PhotoPath { get; set; }
        [Required]
        public Role Role { get; set; }
        [Required]
        public UserStatus UserStatus { get; set; }
        [MinLength(2), MaxLength(25)]
        public string Chair { get; set; }
        [Required, MinLength(8), MaxLength(150)]
        public string Login { get; set; }
        [Required, MinLength(15), MaxLength(300)]
        public string PasswordHash { get; set; }
        [MinLength(5), MaxLength(20)]
        public string StudentRecordBook { get; set; }
        [MinLength(1), MaxLength(5)]
        public string StudentTicketSeries { get; set; }
        [MinLength(3), MaxLength(50)]
        public string StudentTicketNumber { get; set; }
        [MinLength(3), MaxLength(25)]
        public string TeacherCode { get; set; }
        [Required]
        public bool CanEdit { get; set; } = true;
        [Required]
        public bool IsVerified { get; set; } = false;
        [MinLength(100), MaxLength(120)]
        public string LinkVerify { get; set; }
        public DateTime? DateVerified { get; set; }
        [Range(0.0, 5.0)]
        public double Raiting { get; set; }
        public DegreeType Degree { get; set; } //Науковий ступінь
        public AcademicStatusType AcademicStatus { get; set; } //Вчене звання
        [MaxLength(5000)]
        public string ChangeHistory { get; set; }
        public int? GroupId { get; set; }
        public Group Group { get; set; }





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

    public enum Role
    {
        Admin,
        DirectorOfInsitute,
        AssistantDirectorOfInsitute,
        HeadOfDepartment,
        AssistantHeadOfDepartment,
        Teacher,
        Student
    }

    public enum UserStatus
    {
        Teacher,
        //Parent,
        Student
    }

    public enum DegreeType
    {
        DoctorOfTechScience,
        CandidateOfTechScience,
        DoctorOfEconomicScience,
        CandidateOfEconomicScience,
        DoctorOfMathScience,
        CandidateOfMathScience,
    }

    public enum AcademicStatusType
    {
        Professor,
        Docent
    }
}