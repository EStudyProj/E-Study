using EStudy.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EStudy.Infrastructure.Data
{
    public interface IUnitOfWork
    {
        IIHERepository IHEs { get; }
        IUserRepository Users { get; }
    }
}