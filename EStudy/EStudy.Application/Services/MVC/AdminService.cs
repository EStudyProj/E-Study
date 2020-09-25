using AutoMapper;
using EStudy.Application.Interfaces.MVC;
using EStudy.Application.ViewModels.Group;
using EStudy.Domain.Models;
using EStudy.Infrastructure.Data;
using Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EStudy.Application.Services.MVC
{
    public class AdminService : IAdminService
    {
        private readonly IMapper mapper;
        private IUnitOfWork unitOfWork;
        public AdminService(IUnitOfWork _unitOfWork, IMapper _mapper)
        {
            unitOfWork = _unitOfWork;
            mapper = _mapper;
        }

        public async Task<bool> CreateDatabase()
        {
            return await unitOfWork.Users.CreateDatabaseAsync();
        }

        public async Task<string> CreateTestData()
        {

            var admin = new User
            {
                Firstname = "Admin",
                Patronymic = "Amdin",
                Lastname = "Admin",
                Username = "Admin",
                Role = Role.Admin,
                UserStatus = UserStatus.Teacher,
                Login = "a@estudy.com",
                PasswordHash = PasswordManager.GeneratePasswordHash("AdminAdmin"),
                IsVerified = true,
                DateVerified = DateTime.Now,
                CreatedByUserId = 1,
                CreatedFromIPAddress = "34.43.119.37"
            };
            await unitOfWork.Users.CreateAsync(admin);

            var ihe = new IHE
            {
                Name = "Державний університет телекомунікацій",
                ShortName = "ДУТ",
                TypeIHE = TypeIHE.University,
                AreaIHE = "IT (Інформаційні технології)",
                LevelOfAccreditation = "3-4 рівень акредитації",
                TimeStudyOfBakalavr = 4,
                TimeStudyOfMagister = 2,
                History = "Університет євпропейського стандарту, заснований у 2013 році, минулий університет радіозв'язку ім. Попова",
                Description = "Державний університет телекомунікацій навчає студентів різних галузей, від економістів до IT спеціалістів",
                AddressInfo = "Україна, Київ, Соломянська площа 7",
                Locality = "Київ",
                Region = "Київська область",
                PostalCode = "04213",
                CreatedByUserId = 1,
                CreatedFromIPAddress = "34.43.119.37"
            };
            var iheResult = await unitOfWork.IHEs.CreateAsync(ihe);
            if (iheResult != "OK")
                return "Created data crashed at creating IHE";



            var depart1 = new Department
            {
                Name = "Інформаційні технології",
                InstituteName = "Навчально-науковий інститут Інформаційних технологій",
                Shifr = "ІТ",
                HeadById = 1,
                Phone = "+380442154678",
                Description = "",
                IHEId = ihe.Id,
                CreatedByUserId = 1,
                CreatedFromIPAddress = "34.43.119.37"
            };
            var departResult1 = await unitOfWork.Departments.CreateAsync(depart1);
            if (departResult1 != "OK")
                return "Created data crashed at creating Department 1";

            var depart2 = new Department
            {
                Name = "Кібербезпека",
                InstituteName = "Навчально-науковий інститут Захисту інформації",
                Shifr = "КБ",
                HeadById = 2,
                Phone = "+380442154679",
                Description = "",
                IHEId = ihe.Id,
                CreatedByUserId = 1,
                CreatedFromIPAddress = "34.43.119.37"
            };
            var departResult2 = await unitOfWork.Departments.CreateAsync(depart2);
            if (departResult2 != "OK")
                return "Created data crashed at creating Department 2";



            var spec1 = new Specialty
            {
                Name = "Інженерія програмного забезпечення",
                Shifr = "ІПЗ",
                CodeSpec = "121",
                Qualification = TypeDiploma.BachelorsDegree,
                EducationalProgram = "Програміст",
                DepartmentId = depart1.Id,
                CreatedByUserId = 1,
                CreatedFromIPAddress = "34.43.119.37"
            };
            var specResult1 = await unitOfWork.Specialties.CreateAsync(spec1);
            if (iheResult != "OK")
                return "Created data crashed at creating Specialty 1";

            var spec2 = new Specialty
            {
                Name = "Комп'ютерні науки",
                Shifr = "КІ",
                CodeSpec = "122",
                Qualification = TypeDiploma.BachelorsDegree,
                EducationalProgram = "Технік-програміст",
                DepartmentId = depart1.Id,
                CreatedByUserId = 1,
                CreatedFromIPAddress = "34.43.119.37"
            };
            var specResult2 = await unitOfWork.Specialties.CreateAsync(spec2);
            if (specResult2 != "OK")
                return "Created data crashed at creating Specialty 2";

            var spec3 = new Specialty
            {
                Name = "Кібенетичний захист",
                Shifr = "КЗ",
                CodeSpec = "126",
                Qualification = TypeDiploma.BachelorsDegree,
                EducationalProgram = "Технік-захисту",
                DepartmentId = depart2.Id,
                CreatedByUserId = 1,
                CreatedFromIPAddress = "34.43.119.37"
            };
            var specResult3 = await unitOfWork.Specialties.CreateAsync(spec3);
            if (specResult3 != "OK")
                return "Created data crashed at creating Specialty 3";



            var group1 = new Group
            {
                GroupName = "ПД-24",
                IndexItemToChanged = 3,
                CodeForConnect = Generator.GetString(10),
                SpecialtyId = spec1.Id,
                CreatedByUserId = 1,
                CreatedFromIPAddress = "34.43.119.37"
            };
            var groupRes1 = await unitOfWork.Groups.CreateAsync(group1);
            if (groupRes1 != "OK")
                return "Created data crashed at creating Group 1";

            var group2 = new Group
            {
                GroupName = "КНД-23",
                IndexItemToChanged = 3,
                CodeForConnect = Generator.GetString(10),
                SpecialtyId = spec2.Id,
                CreatedByUserId = 1,
                CreatedFromIPAddress = "34.43.119.37"
            };
            var groupRes2 = await unitOfWork.Groups.CreateAsync(group2);
            if (groupRes2 != "OK")
                return "Created data crashed at creating Group 2";



            var student1 = new User
            {
                Firstname = "Ярослав",
                Patronymic = "Юрійович",
                Lastname = "Мудрик",
                Username = "Yarik08",
                Role = Role.Student,
                UserStatus = UserStatus.Student,
                Login = "yaroslav.mudryk@gmail.com",
                PasswordHash = PasswordManager.GeneratePasswordHash("Yaroslav266210"),
                GroupId = group1.Id,
                IsVerified = true,
                DateVerified = DateTime.Now,
                CreatedByUserId = 1,
                CreatedFromIPAddress = "34.43.119.37"
            };
            var userRes1 = await unitOfWork.Users.CreateAsync(student1);
            if (userRes1 != "OK")
                return "Created data crashed at creating Student 1";

            var student2 = new User
            {
                Firstname = "Микита",
                Patronymic = "Михайлович",
                Lastname = "Медко",
                Username = "Barbossa1800",
                Role = Role.Student,
                UserStatus = UserStatus.Student,
                Login = "nikita.jove28@gmail.com",
                PasswordHash = PasswordManager.GeneratePasswordHash("Nikita266210"),
                GroupId = group1.Id,
                IsVerified = true,
                DateVerified = DateTime.Now,
                CreatedByUserId = 1,
                CreatedFromIPAddress = "34.43.119.37"
            };
            var userRes2 = await unitOfWork.Users.CreateAsync(student2);
            if (userRes2 != "OK")
                return "Created data crashed at creating Student 2";

            var student3 = new User
            {
                Firstname = "Михайло",
                Patronymic = "Сергійович",
                Lastname = "Брехов",
                Username = "RevenNol",
                Role = Role.Student,
                UserStatus = UserStatus.Student,
                Login = "brekhov@gmail.com",
                PasswordHash = PasswordManager.GeneratePasswordHash("Misha0803"),
                GroupId = group2.Id,
                IsVerified = true,
                DateVerified = DateTime.Now,
                CreatedByUserId = 1,
                CreatedFromIPAddress = "34.43.119.37"
            };
            var userRes3 = await unitOfWork.Users.CreateAsync(student3);
            if (userRes3 != "OK")
                return "Created data crashed at creating Student 3";



            var diploma = new Diploma
            {
                TypeDiploma = TypeDiploma.BachelorsDegree,
                SeriesDiploma = "EF",
                NumberDiploma = "192092",
                PresentedAt = DateTime.Parse("25.06.2020"),
                Firstname = "Ярослав",
                Patronymic = "Юрійович",
                Lastname = "Мудрик",
                IHEFullName = "Державний університет телекомунікацій",
                Specialty = "Інженерія програмного забезпечення",
                EducationalProgram = "ШРТГА",
                ProfessionalQualification = "Бакалавр",
                NameOfRector = "Толубко В.Б.",
                IsRed = true,
                UserId = 2,
                CreatedByUserId = 1,
                CreatedFromIPAddress = "34.43.119.37"
            };
            await unitOfWork.Diplomas.CreateAsync(diploma);
            return "OK";
        }

        public async Task<bool> DropDatabase()
        {
            return await unitOfWork.Users.DropDatabaseAsync();
        }
    }
}