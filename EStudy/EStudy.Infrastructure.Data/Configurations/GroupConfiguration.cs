using EStudy.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
namespace EStudy.Infrastructure.Data.Configurations
{
    public class GroupConfiguration : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder.HasKey(d => d.Id);
            builder.HasIndex(d => new
            {
                d.ClassHeadId,
                d.CodeForConnect,
                d.EmailByGroup,
                d.GroupName,
                d.IndexItemToChanged,
                d.IsShowEmail,
                d.Released,
                d.SpecialtyId
            }); 
        }
    }
}