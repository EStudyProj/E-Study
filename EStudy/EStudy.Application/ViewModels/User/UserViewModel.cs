using EStudy.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
namespace EStudy.Application.ViewModels.User
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Firstname { get; set; }
        public string Patronymic { get; set; }
        public string Lastname { get; set; }
        public DateTime? Born { get; set; }
        public string Username { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string PhotoPath { get; set; }
        public UserStatus UserStatus { get; set; }
        public string Chair { get; set; }
        public string StudentRecordBook { get; set; }
        public string StudentTicketSeries { get; set; }
        public string StudentTicketNumber { get; set; }
        public string TeacherCode { get; set; }
        public string Description { get; set; }
        public bool IsVerified { get; set; }
        public double Raiting { get; set; }
        public DegreeType Degree { get; set; } //Науковий ступінь
        public AcademicStatusType AcademicStatus { get; set; } //Вчене звання
        public bool IsEdit { get; set; }
        public DateTime? DateLastEdit { get; set; }
    }
}