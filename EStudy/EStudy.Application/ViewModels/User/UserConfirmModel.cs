using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace EStudy.Application.ViewModels.User
{
    public class UserConfirmModel : EditModel
    {
        [Required]
        public int Type { get; set; }
        [Required, MinLength(100), MaxLength(120)]
        public string LinkVerify { get; set; }
        [MinLength(6), MaxLength(12)]
        public string ConnectGroup { get; set; }
    }
}