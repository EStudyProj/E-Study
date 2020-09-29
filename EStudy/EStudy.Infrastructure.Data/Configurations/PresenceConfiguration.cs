using EStudy.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
namespace EStudy.Infrastructure.Data.Configurations
{
    public class PresenceConfiguration : IEntityTypeConfiguration<Presence>
    {
        public void Configure(EntityTypeBuilder<Presence> builder)
        {
            builder.HasKey(d => d.Id);
            builder.HasIndex(d => new
            {
                d.LessonId,
                d.Presents,
                d.StudentId
            });
        }
    }
}