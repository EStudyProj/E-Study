using System;
using System.Collections.Generic;
using System.Text;
namespace EStudy.Application.ViewModels.Department
{
    public class DepartmentViewModel
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Name { get; set; }
        public string InstituteName { get; set; }
        public string Shifr { get; set; }
        public int HeadById { get; set; }
        public string Phone { get; set; }
        public string Description { get; set; }
        public bool IsEdit { get; set; }
        public DateTime DateLastEdit { get; set; }
        public IHEViewModel IHE { get; set; }
    }
}