using EStudy.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
namespace EStudy.Infrastructure.Data.Configurations
{
    public class TaskConfiguration : IEntityTypeConfiguration<Task>
    {
        public void Configure(EntityTypeBuilder<Task> builder)
        {
            builder.HasKey(d => d.Id);
            builder.HasIndex(d => new
            {
                d.Text,
                d.MaxMarkByThisTask,
                d.DueDate,
                d.LessonId
            });
        }
    }
}