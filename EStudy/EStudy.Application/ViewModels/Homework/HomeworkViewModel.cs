using EStudy.Application.ViewModels.Task;
using System;
using System.Collections.Generic;
using System.Text;

namespace EStudy.Application.ViewModels.Homework
{
    public class HomeworkViewModel
    {
        public long Id { get; set; }
        public bool IsComplate { get; set; }
        public int? ComplateByStudentId { get; set; }
        public DateTime? DateComplated { get; set; }
        public string Text { get; set; }
        public int TeacherSetId { get; set; }
        public TaskViewModel Task { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsEdit { get; set; }
        public DateTime? DateLastEdit { get; set; }
    }
}
