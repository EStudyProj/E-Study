using EStudy.Application.ViewModels.Lesson;
using EStudy.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
namespace EStudy.Application.ViewModels.Presence
{
    public class PresenceViewModel
    {
        public long Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public int StudentId { get; set; }
        public PresentsType Presents { get; set; }
        public LessonViewModel Lesson { get; set; }
        public bool IsEdit { get; set; }
        public DateTime? DateLastEdit { get; set; }
    }
}