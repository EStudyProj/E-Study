using EStudy.Application.ViewModels.Homework;
using EStudy.Application.ViewModels.Lesson;
using EStudy.Application.ViewModels.Mark;
using System;
using System.Collections.Generic;
using System.Text;
namespace EStudy.Application.ViewModels.Task
{
    public class TaskViewModel
    {
        public long Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Text { get; set; }
        public int MaxMarkByThisTask { get; set; }
        public DateTime? DueDate { get; set; }
        public LessonViewModel Lesson { get; set; }
        public List<HomeworkViewModel> Homeworks { get; set; }
        public List<MarkViewModel> Marks { get; set; }
        public bool IsEdit { get; set; }
        public DateTime? DateLastEdit { get; set; }
    }
}