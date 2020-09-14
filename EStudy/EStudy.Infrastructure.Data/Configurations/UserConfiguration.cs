using EStudy.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
namespace EStudy.Infrastructure.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(d => d.Id);
            builder.HasIndex(d => new
            {
                d.Firstname,
                d.Patronymic,
                d.Lastname,
                d.Username,
                d.UserStatus,
                d.Role,
                d.Login,
                d.Born,
                d.Email,
                d.Phone,
                d.Chair,
                d.LinkVerify,
                d.StudentRecordBook,
                d.StudentTicketNumber,
                d.StudentTicketSeries,
                d.TeacherCode
            });
        }
    }
}