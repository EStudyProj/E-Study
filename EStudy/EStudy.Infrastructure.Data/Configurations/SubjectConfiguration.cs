using EStudy.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
namespace EStudy.Infrastructure.Data.Configurations
{
    public class SubjectConfiguration : IEntityTypeConfiguration<Subject>
    {
        public void Configure(EntityTypeBuilder<Subject> builder)
        {
            builder.HasKey(d => d.Id);
            builder.HasIndex(d => new
            {
                d.Name,
                d.ShortName,
                d.CourseName,
                d.TeacherId,
                d.MaxMarkUpToExam,
                d.MaxMarkOnExam,
                d.CommonHours,
                d.NumberSemesters,
                d.FinalMark,
                d.TypeSubject
            });
        }
    }
}