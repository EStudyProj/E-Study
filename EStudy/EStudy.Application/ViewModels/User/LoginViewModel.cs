using System;
using System.Collections.Generic;
using System.Text;
namespace EStudy.Application.ViewModels.User
{
    public class LoginViewModel
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Username { get; set; }
        public string Role { get; set; }
        public string UserStatus { get; set; }
        public string Photo { get; set; }

        public bool NotFoundByLogin { get; set; } = false;
        public bool InvalidPassword { get; set; } = false;
    }
}