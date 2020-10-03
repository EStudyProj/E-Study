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
        IDepartmentRepository departRepos;
        IDiplomaRepository diplomaRepos;
        IFileRepository fileRepos;
        IGroupRepository groupRepos;
        IGroupSubjectRepository groupsubjRepos;
        IHomeworkRepository homeworkRepos;
        IIHERepository iheRepos;
        ILessonRepository lessRepos;
        IMarkRepository markRepos;
        IPresenceRepository presRepos;
        IScheduleRepository scheduleRepos;
        IScheduleAudienceRepository scheduleAudienceRepos;
        IScheduleDayOfWeekRepository scheduleDayOfWeekRepos;
        IScheduleDisciplineRepository scheduleDisciplineRepos;
        IScheduleGroupRepository scheduleGroupRepos;
        IScheduleLessonRepository scheduleLessonRepos;
        IScheduleParityOfWeekRepository scheduleParityOfWeekRepos;
        IScheduleTypeLessonRepository scheduleTypeLessonRepos;
        ISpecialtyRepository specRepos;
        ISubjectRepository subjRepos;
        ITaskRepository taskRepos;
        ITestEntityRepository testEntityRepos;
        IUserRepository userRepos;

        public UnitOfWork(
            IDepartmentRepository _departRepos,
            IDiplomaRepository _diplomaRepos,
            IFileRepository _fileRepos,
            IGroupRepository _groupRepos,
            IGroupSubjectRepository _groupsubjRepos,
            IHomeworkRepository _homeworkRepos,
            IIHERepository _iheRepos,
            ILessonRepository _lessRepos,
            IMarkRepository _markRepos,
            IPresenceRepository _presRepos,
            IScheduleRepository _scheduleRepos,
            IScheduleAudienceRepository _scheduleAudienceRepos,
            IScheduleDayOfWeekRepository _scheduleDayOfWeekRepos,
            IScheduleDisciplineRepository _scheduleDisciplineRepos,
            IScheduleGroupRepository _scheduleGroupRepos,
            IScheduleLessonRepository _scheduleLessonRepos,
            IScheduleParityOfWeekRepository _scheduleParityOfWeekRepos,
            IScheduleTypeLessonRepository _scheduleTypeLessonRepos,
            ISpecialtyRepository _specRepos,
            ISubjectRepository _subjRepos,
            ITaskRepository _taskRepos,
            ITestEntityRepository _testEntityRepos,
            IUserRepository _userRepos
            )
        {
            departRepos = _departRepos;
            diplomaRepos = _diplomaRepos;
            fileRepos = _fileRepos;
            groupRepos = _groupRepos;
            groupsubjRepos = _groupsubjRepos;
            homeworkRepos = _homeworkRepos;
            iheRepos = _iheRepos;
            lessRepos = _lessRepos;
            markRepos = _markRepos;
            presRepos = _presRepos;
            scheduleRepos = _scheduleRepos;
            scheduleAudienceRepos = _scheduleAudienceRepos;
            scheduleDayOfWeekRepos = _scheduleDayOfWeekRepos;
            scheduleDisciplineRepos = _scheduleDisciplineRepos;
            scheduleGroupRepos = _scheduleGroupRepos;
            scheduleLessonRepos = _scheduleLessonRepos;
            scheduleParityOfWeekRepos = _scheduleParityOfWeekRepos;
            scheduleTypeLessonRepos = _scheduleTypeLessonRepos;
            specRepos = _specRepos;
            subjRepos = _subjRepos;
            taskRepos = _taskRepos;
            testEntityRepos = _testEntityRepos;
            userRepos = _userRepos;
        }

        public IDepartmentRepository Departments => departRepos;
        public IDiplomaRepository Diplomas => diplomaRepos;
        public IFileRepository Files => fileRepos;
        public IGroupRepository Groups => groupRepos;
        public IGroupSubjectRepository GroupSubjects => groupsubjRepos;
        public IHomeworkRepository Homeworks => homeworkRepos;
        public IIHERepository IHEs => iheRepos;
        public ILessonRepository Lessons => lessRepos;
        public IMarkRepository Marks => markRepos;
        public IPresenceRepository Presences => presRepos;
        public IScheduleRepository Schedules => scheduleRepos;
        public IScheduleAudienceRepository ScheduleAudiences => scheduleAudienceRepos;
        public IScheduleDayOfWeekRepository ScheduleDayOfWeeks => scheduleDayOfWeekRepos;
        public IScheduleDisciplineRepository ScheduleDisciplines => scheduleDisciplineRepos;
        public IScheduleGroupRepository ScheduleGroups => scheduleGroupRepos;
        public IScheduleLessonRepository ScheduleLessons => scheduleLessonRepos;
        public IScheduleParityOfWeekRepository ScheduleParityOfWeeks => scheduleParityOfWeekRepos;
        public IScheduleTypeLessonRepository ScheduleTypeLessons => scheduleTypeLessonRepos;
        public ISpecialtyRepository Specialties => specRepos;
        public ISubjectRepository Subjects=> subjRepos;
        public ITaskRepository Tasks => taskRepos;
        public ITestEntityRepository Tests => testEntityRepos;
        public IUserRepository Users => userRepos;

    }
}