using EStudy.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace EStudy.Application.ViewModels.User
{
    public class RegisterViewModel : EditModel
    {
        [Required, MinLength(2), MaxLength(50)]
        public string Firstname { get; set; }
        [Required, MinLength(3), MaxLength(50)]
        public string Patronymic { get; set; }
        [Required, MinLength(2), MaxLength(50)]
        public string Lastname { get; set; }
        [Required, MinLength(8), MaxLength(150)]
        public string Login { get; set; }
        [Required, MinLength(8), MaxLength(50)]
        public string Password { get; set; }
        public Role Role { get; set; }
        public UserStatus UserStatus { get; set; }
    }
}