using EStudy.Application.ViewModels.Department;
using EStudy.Application.ViewModels.Group;
using EStudy.Application.ViewModels.User;
using EStudy.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
namespace EStudy.Application.ViewModels.Specialty
{
    public class SpecialtyViewModel
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Name { get; set; }
        public string Shifr { get; set; }
        public string CodeSpec { get; set; }
        public TypeDiploma Qualification { get; set; }
        public string EducationalProgram { get; set; }
        public string ProfessionalQualification { get; set; }
        public DepartmentViewModel Department { get; set; }
        public List<GroupViewModel> Groups { get; set; }
        public bool IsEdit { get; set; }
        public DateTime? DateLastEdit { get; set; }
    }
}