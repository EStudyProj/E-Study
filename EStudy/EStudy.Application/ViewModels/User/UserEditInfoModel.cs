using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace EStudy.Application.ViewModels.User
{
    public class UserEditInfoModel : EditModel
    {
        [MinLength(5), MaxLength(30)]
        public string Phone { get; set; }
        public bool IsShowPhone { get; set; }
        [MinLength(7), MaxLength(100)]
        public string Email { get; set; }
        public bool IsShowEmail { get; set; }
    }
}