using EStudy.Application.ViewModels.User;
using EStudy.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
namespace EStudy.Application.ViewModels.DIploma
{
    public class DiplomaViewModel
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public TypeDiploma TypeDiploma { get; set; }
        public string SeriesDiploma { get; set; }
        public string NumberDiploma { get; set; }
        public DateTime? PresentedAt { get; set; }
        public string Firstname { get; set; }
        public string Patronymic { get; set; }
        public string Lastname { get; set; }
        public string IHEFullName { get; set; }
        public string Specialty { get; set; }
        public string EducationalProgram { get; set; }
        public string ProfessionalQualification { get; set; }
        public string NameOfRector { get; set; }
        public string PathToPrinting { get; set; }
        public string PathToSignature { get; set; }
        public bool IsRed { get; set; }
        public bool InPass { get; set; }
        public string UniqCode { get; set; }
        public UserViewModel User { get; set; }
        public bool IsEdit { get; set; }
        public DateTime? DateLastEdit { get; set; }
    }
}