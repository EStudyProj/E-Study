using EStudy.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EStudy.Infrastructure.Data
{
    public interface IUnitOfWork
    {
        IDepartmentRepository Departments { get; }
        IDiplomaRepository Diplomas { get; }
        IFileRepository Files { get; }
        IGroupRepository Groups { get; }
        IGroupSubjectRepository GroupSubjects { get; }
        IHomeworkRepository Homeworks { get; }
        IIHERepository IHEs { get; }
        ILessonRepository Lessons { get; }
        IMarkRepository Marks { get; }
        IPresenceRepository Presences { get; }
        ISpecialtyRepository Specialties { get; }
        ISubjectRepository Subjects { get; }
        ITaskRepository Tasks { get; }
        ITestEntityRepository Tests { get; }
        IUserRepository Users { get; }
    }
}