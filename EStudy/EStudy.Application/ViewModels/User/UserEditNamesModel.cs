using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace EStudy.Application.ViewModels.User
{
    public class UserEditNamesModel : EditModel
    {
        [Required, MinLength(2), MaxLength(50)]
        public string Firstname { get; set; }
        [Required, MinLength(3), MaxLength(50)]
        public string Patronymic { get; set; }
        [Required, MinLength(2), MaxLength(50)]
        public string Lastname { get; set; }
    }
}