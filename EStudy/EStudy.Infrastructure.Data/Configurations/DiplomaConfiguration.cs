using EStudy.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
namespace EStudy.Infrastructure.Data.Configurations
{
    public class DiplomaConfiguration : IEntityTypeConfiguration<Diploma>
    {
        public void Configure(EntityTypeBuilder<Diploma> builder)
        {
            builder.HasKey(d => d.Id);
            builder.HasIndex(d => new
            {
                d.IsRed,
                d.InPass,
                d.UniqCode,
            });
        }
    }
}