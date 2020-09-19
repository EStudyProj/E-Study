using EStudy.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace EStudy.Application.ViewModels.IHE
{
    public class IHECreateModel : EditModel
    {
        [Required, MinLength(3), MaxLength(200)]
        public string Name { get; set; }
        [Required, MinLength(2), MaxLength(25)]
        public string ShortName { get; set; }
        [Required]
        public IHEType IHEType { get; set; }
        [Required, MinLength(2), MaxLength(100)]
        public string AreaIHE { get; set; } //напрям
        [Required, MinLength(1), MaxLength(75)]
        public string LevelOfAccreditation { get; set; }
        [Required]
        public double TimeStudyOfMagister { get; set; }
        [Required]
        public double TimeStudyOfBakalavr { get; set; }

        public TypeIHE TypeIHE { get; set; }
    }

    public enum IHEType
    {
        Університет,
        Інститут,
        Коледж,
        Технікум
    }
}