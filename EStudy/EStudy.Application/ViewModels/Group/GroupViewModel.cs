using EStudy.Application.ViewModels.Specialty;
using EStudy.Application.ViewModels.User;
using System;
using System.Collections.Generic;
using System.Text;
namespace EStudy.Application.ViewModels.Group
{
    public class GroupViewModel
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string GroupName { get; set; }
        public byte IndexItemToChanged { get; set; }
        public bool Released { get; set; }
        public string CodeForConnect { get; set; }
        public string AdditionalInfo { get; set; }
        public string EmailByGroup { get; set; }
        public string LoginToEmail { get; set; }
        public string PasswordToEmail { get; set; }
        public bool IsShowEmail { get; set; }
        public int? ClassHeadId { get; set; }
        public bool IsEdit { get; set; }
        public DateTime? DateLastEdit { get; set; }
        public SpecialtyViewModel Specialty { get; set; }
        public List<UserViewModel> Students { get; set; }
    }
}