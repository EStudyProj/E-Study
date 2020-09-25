using EStudy.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace EStudy.Application.ViewModels.Subject
{
    public class SubjectCreateModel : EditModel
    {
        [Required, MinLength(2), MaxLength(50)]
        public string Name { get; set; }
        [Required]
        public int TeacherId { get; set; }
        [Required]
        public bool WithExam { get; set; } = false;
        [Required]
        public int MaxMarkUpToExam { get; set; }
        [Required]
        public int MaxMarkOnExam { get; set; }
        [Required]
        public int CommonHours { get; set; }
        [Required]
        public TypeSubject TypeSubject { get; set; }
        [Required]
        public MarkType FinalMark { get; set; }
        [Required]
        public int NumberSemesters { get; set; }
    }
}