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
        public UnitOfWork(IIHERepository _iheRepos, IUserRepository _userRepos, ITestEntityRepository _testEntityRepos, IDepartmentRepository _departRepos)
        {
            iheRepos = _iheRepos;
            userRepos = _userRepos;
            testEntityRepos = _testEntityRepos;
            departRepos = _departRepos;
        }


        public IIHERepository IHEs => iheRepos;
        public IUserRepository Users => userRepos;
        public ITestEntityRepository Tests => testEntityRepos;
        public IDepartmentRepository Departments => departRepos;
    }
}