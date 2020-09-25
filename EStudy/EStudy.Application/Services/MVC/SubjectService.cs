using AutoMapper;
using EStudy.Application.Interfaces.MVC;
using EStudy.Application.ViewModels.Subject;
using EStudy.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EStudy.Application.Services.MVC
{
    public class SubjectService : ISubjectService
    {
        private readonly IMapper mapper;
        private IUnitOfWork unitOfWork;
        public SubjectService(IUnitOfWork _unitOfWork, IMapper _mapper)
        {
            unitOfWork = _unitOfWork;
            mapper = _mapper;
        }

        public async Task<SubjectViewModel> GetSubjectById(int Id)
        {
            var subj = await unitOfWork.Subjects.GetByWhereAsync(d => d.Id == Id);
            return mapper.Map<SubjectViewModel>(subj);
        }

        public async Task<List<SubjectViewModel>> GetSubjectsByName(string name)
        {
            var subjs = await unitOfWork.Subjects.GetListByWhereAsync(d => d.Name.Contains(name));
            return mapper.Map<List<SubjectViewModel>>(subjs);
        }
    }
}