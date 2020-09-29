using EStudy.Application.ViewModels.Mark;
using EStudy.Application.ViewModels.Presence;
using EStudy.Application.ViewModels.Subject;
using EStudy.Application.ViewModels.Task;
using EStudy.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
namespace EStudy.Application.ViewModels.Lesson
{
    public class LessonViewModel
    {
        public long Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Theme { get; set; }
        public string Text { get; set; }
        public DateTime DateLesson { get; set; }
        public int AssignedToTeacherId { get; set; }
        public bool IsHindFromStudent { get; set; }
        public bool IsReplacement { get; set; }
        public int? TeacherReplacementId { get; set; }
        public TypeLesson TypeLesson { get; set; }
        public SubjectViewModel Subject { get; set; }
        public List<TaskViewModel> Tasks { get; set; }
        public List<MarkViewModel> Marks { get; set; }
        public List<PresenceViewModel> Presences { get; set; }
        public bool IsEdit { get; set; } = false;
        public DateTime? DateLastEdit { get; set; }
    }
}