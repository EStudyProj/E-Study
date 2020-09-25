using System;
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
        [Required]
        public int MaxMarkUpToExam { get; set; }
        [Required]
        public int MaxMarkOnExam { get; set; }
        [Required]
        public int CommonHours { get; set; }
        public int HoursPracticalTasks { get; set; }
        public int HoursSeminarTasks { get; set; }
        public int HoursLectures { get; set; }
        [Required]
        public TypeSubject TypeSubject { get; set; }
        [MinLength(5), MaxLength(1000)]
        public string Literature { get; set; }
        [Required]
        public MarkType FinalMark { get; set; }
        [Required]
        public int NumberSemesters { get; set; }
        //public List<Lesson> Lessons { get; set; }
        public List<GroupSubject> GroupSubjects { get; set; }





        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        [Required, MinLength(3), MaxLength(30)]
        public string CreatedFromIPAddress { get; set; }
        [Required]
        public int CreatedByUserId { get; set; }
        [Required]
        public bool IsEdit { get; set; } = false;
        public DateTime? DateLastEdit { get; set; }
        [MinLength(3), MaxLength(30)]
        public string EditedFromIPAddress { get; set; }
        public int? LastEditedByUserId { get; set; }
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