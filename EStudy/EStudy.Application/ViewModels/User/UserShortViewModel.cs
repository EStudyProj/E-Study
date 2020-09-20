using EStudy.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
namespace EStudy.Application.ViewModels.User
{
    public class UserShortViewModel
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Patronymic { get; set; }
        public string Lastname { get; set; }
        public string Username { get; set; }
        public UserStatus UserStatus { get; set; }
        public string Photo { get; set; }
    }
}