using EStudy.Domain.Interfaces;
using EStudy.Domain.Models;
using EStudy.Infrastructure.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
namespace EStudy.Infrastructure.Data.Configurations
{
    public class SpecialtyConfiguration : IEntityTypeConfiguration<Specialty>
    {
        public void Configure(EntityTypeBuilder<Specialty> builder)
        {
            builder.HasKey(d => d.Id);
            builder.HasIndex(i => new
            {
                i.Name,
                i.CodeSpec,
                i.DepartmentId,
                i.ProfessionalQualification,
                i.Qualification,
                i.Shifr
            });
        }
    }
}