using EStudy.Domain.Interfaces;
using EStudy.Domain.Models;
using EStudy.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;
namespace EStudy.Infrastructure.Data.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        private readonly EStudyContext db;
        public UserRepository(EStudyContext db) : base(db)
        {
            this.db = db;
        }



    }
}