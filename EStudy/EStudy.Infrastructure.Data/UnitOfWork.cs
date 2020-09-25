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
        private IGroupRepository groupRepos;
        private ISubjectRepository subjRepos;
        private IGroupSubjectRepository groupsubjRepos;

        public UnitOfWork(IIHERepository _iheRepos,
            IUserRepository _userRepos,
            ITestEntityRepository _testEntityRepos,
            IDepartmentRepository _departRepos,
            ISpecialtyRepository _specRepos,
            IGroupRepository _groupRepos,
            ISubjectRepository _subjRepos,
            IGroupSubjectRepository _groupsubjRepos)
        {
            iheRepos = _iheRepos;
            userRepos = _userRepos;
            testEntityRepos = _testEntityRepos;
            departRepos = _departRepos;
            specRepos = _specRepos;
            groupRepos = _groupRepos;
            subjRepos = _subjRepos;
            groupsubjRepos = _groupsubjRepos;
        }

        public IIHERepository IHEs => iheRepos;
        public IUserRepository Users => userRepos;
        public ITestEntityRepository Tests => testEntityRepos;
        public IDepartmentRepository Departments => departRepos;
        public ISpecialtyRepository Specialties => specRepos;
        public IGroupRepository Groups => groupRepos;
        public ISubjectRepository Subjects=> subjRepos;
        public IGroupSubjectRepository GroupSubjects => groupsubjRepos;
    }
}