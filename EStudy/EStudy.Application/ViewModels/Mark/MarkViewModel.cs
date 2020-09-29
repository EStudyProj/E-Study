using EStudy.Application.ViewModels.Lesson;
using EStudy.Application.ViewModels.Task;
using EStudy.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
namespace EStudy.Application.ViewModels.Mark
{
    public class MarkViewModel
    {
        public long Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public int Value { get; set; }
        public string Description { get; set; }
        public TypeMark TypeMark { get; set; }
        public int TeacherSetId { get; set; }
        public bool IsHindFromStudents { get; set; }
        public LessonViewModel Lesson { get; set; }
        public TaskViewModel Task { get; set; }
        public bool IsEdit { get; set; }
        public DateTime? DateLastEdit { get; set; }
    }
}