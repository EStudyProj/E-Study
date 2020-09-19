using EStudy.Domain.Interfaces;
using EStudy.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EStudy.Infrastructure.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private IIHERepository iheRepos;
        private IUserRepository userRepos;
        private ITestEntityRepository testEntityRepos;
        private IDepartmentRepository departRepos;
        private ISpecialtyRepository specRepos;
        public UnitOfWork(IIHERepository _iheRepos, IUserRepository _userRepos, ITestEntityRepository _testEntityRepos, IDepartmentRepository _departRepos, ISpecialtyRepository _specRepos)
        {
            iheRepos = _iheRepos;
            userRepos = _userRepos;
            testEntityRepos = _testEntityRepos;
            departRepos = _departRepos;
            specRepos = _specRepos;
        }


        public IIHERepository IHEs => iheRepos;
        public IUserRepository Users => userRepos;
        public ITestEntityRepository Tests => testEntityRepos;
        public IDepartmentRepository Departments => departRepos;
        public ISpecialtyRepository Specialties => specRepos;
    }
}