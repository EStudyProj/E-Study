using System;
using System.Collections.Generic;
using System.Text;
namespace EStudy.Application.ViewModels.Subject
{
    public class SubjectViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string CourseName { get; set; }
        public int TeacherId { get; set; }
        public bool WithExam { get; set; }
        public int MaxMarkUpToExam { get; set; }
        public int MaxMarkOnExam { get; set; }
        public int CommonHours { get; set; }
        public int? HoursPracticalTasks { get; set; }
        public int? HoursSeminarTasks { get; set; }
        public int? HoursLectures { get; set; }
        public string TypeSubject { get; set; }
        public string Literature { get; set; }
        public string FinalMark { get; set; }
        public int NumberSemesters { get; set; }
    }
}