using EStudy.Application.ViewModels.Department;
using EStudy.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
namespace EStudy.Application.ViewModels.IHE
{
    public class IHEViewModel
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public TypeIHE TypeIHE { get; set; }
        public string AreaIHE { get; set; } //напрям
        public string LevelOfAccreditation { get; set; }
        public double TimeStudyOfMagister { get; set; }
        public double TimeStudyOfBakalavr { get; set; }
        public string PhotoPath { get; set; }
        public string Logo25 { get; set; }
        public string Logo50 { get; set; }
        public string Logo100 { get; set; }
        public string LogoMax { get; set; }
        public string History { get; set; }
        public int HeadOfIheId { get; set; }
        public string Description { get; set; }
        public bool IsEdit { get; set; } = false;
        public DateTime? DateLastEdit { get; set; }
        public string AddressInfo { get; set; }
        public string Locality { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string PhoneHumanResourcesDepartment { get; set; } //Відділ кадрів
        public string PhoneAccounting { get; set; } //Бухгалтерія
        public string PhoneSelectionCommittee { get; set; } //Приймальна комісія
        public string ReceptionOfTheDirector { get; set; } // Приймальня директора
        public string PhoneLibrary { get; set; } //Телефон бібліотеки
        public List<DepartmentViewModel> Departments { get; set; }
    }
}