﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace EStudy.Domain.Models
{
    public class Subject
    {
        [Key]
        public int Id { get; set; }
        [Required, MinLength(2), MaxLength(50)]
        public string Name { get; set; }
        [MinLength(2), MaxLength(10)]
        public string ShortName { get; set; }
        [MinLength(3), MaxLength(50)]
        public string CourseName { get; set; }
        [Required]
        public int TeacherId { get; set; }
        [Required]
        public bool WithExam { get; set; } = false;
        public int MaxMarkUpToExam { get; set; }
        public int MaxMarkOnExam { get; set; }
        public int CommonHours { get; set; }
        public int? HoursPracticalTasks { get; set; }
        public int? HoursSeminarTasks { get; set; }
        public int? HoursLectures { get; set; }
        public TypeSubject TypeSubject { get; set; }
        [MinLength(5), MaxLength(1000)]
        public string Literature { get; set; }
        [Required]
        public MarkType FinalMark { get; set; }
        [Required]
        public int NumberSemesters { get; set; }
        //public List<Lesson> Lessons { get; set; }
        //public List<GroupSubject> GroupSubjects { get; set; }
    }

    public enum TypeSubject
    {
        Regular,
        Practical,
        Course,
        Diploma
    }
    public enum PreparationLevel
    {
        Starter,
        Essential,
        Advanced,
        Professional
    }

    public enum MarkType
    {
        Average,
        Sum
    }
}