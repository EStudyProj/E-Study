using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace EStudy.Application.ViewModels.User
{
    public class AuthViewModel
    {
        [Required, MinLength(8), MaxLength(150)]
        public string Login { get; set; }
        [Required, MinLength(8), MaxLength(75), DataType(DataType.Password)]
        public string Password { get; set; }
    }
}