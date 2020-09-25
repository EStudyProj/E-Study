using EStudy.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EStudy.Application.Interfaces.MVC
{
    public interface IDiplomaService
    {
        System.Threading.Tasks.Task<Diploma> GetByCode(string code);
    }
}
