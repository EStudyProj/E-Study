using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace EStudy.Application.ViewModels.User
{
    public class UserEditDescriptionModel : EditModel
    {
        public DateTime Born { get; set; }
        [MinLength(1), MaxLength(300)]
        public string Description { get; set; }
    }
}