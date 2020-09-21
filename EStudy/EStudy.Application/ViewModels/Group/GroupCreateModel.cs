using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace EStudy.Application.ViewModels.Group
{
    public class GroupCreateModel : EditModel
    {
        [Required, MinLength(2), MaxLength(20)]
        public string GroupName { get; set; }
        [Required]
        public byte IndexItemToChanged { get; set; }
        [MinLength(5), MaxLength(7)]
        public string CodeForConnect { get; set; }
        public int SpecialtyId { get; set; }
    }
}