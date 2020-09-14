using EStudy.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
namespace EStudy.Infrastructure.Data.Configurations
{
    public class IHEConfiguration : IEntityTypeConfiguration<IHE>
    {
        public void Configure(EntityTypeBuilder<IHE> builder)
        {
            builder.HasKey(d => d.Id);
            builder.HasIndex(d => new
            {
                d.Name,
                d.ShortName,
                d.StudentCode,
                d.TeacherCode,
                d.Region,
                d.AreaIHE,
                d.Locality,
                d.LevelOfAccreditation
            });
        }
    }
}