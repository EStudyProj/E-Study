using EStudy.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EStudy.Domain.Interfaces
{
    public interface ISpecialtyRepository : IRepository<Specialty>
    {
        Task<Specialty> GetSpecialtyWithGroupsById(int Id);
    }
}