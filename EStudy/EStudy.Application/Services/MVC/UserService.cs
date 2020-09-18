using AutoMapper;
using EStudy.Application.Interfaces.MVC;
using EStudy.Application.ViewModels;
using EStudy.Application.ViewModels.User;
using EStudy.Domain.Interfaces;
using EStudy.Domain.Models;
using EStudy.Infrastructure.Data;
using System;
using Extensions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStudy.Application.Services.MVC
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork UnitOfWork;
        private readonly IMapper mapper;
        public UserService(IUnitOfWork _UnitOfWork, IMapper _mapper)
        {
            UnitOfWork = _UnitOfWork;
            mapper = _mapper;
        }

        public async Task<string> ChangeDescription(UserEditDescriptionModel model)
        {
            var user = await UnitOfWork.Users.GetByWhereAsTrackingAsync(d => d.Id == model.Id);
            if (user == null)
                return "User by id not found";
            user.Description = model.Description;
            user.Born = model.Born;
            user.LastEditedByUserId = model.UserEditId;
            user.IsEdit = true;
            user.DateLastEdit = DateTime.Now;
            user.EditedFromIPAddress = model.IPAddress;
            return await UnitOfWork.Users.EditAsync(user);
        }

        public async Task<string> ChangeInfo(UserEditInfoModel model)
        {
            var user = await UnitOfWork.Users.GetByWhereAsTrackingAsync(d => d.Id == model.Id);
            if (user == null)
                return "User not found";
            user.Phone = model.Phone;
            user.IsShowPhone = model.IsShowPhone;
            user.Email = model.Email;
            user.IsShowEmail = model.IsShowEmail;
            user.LastEditedByUserId = model.UserEditId;
            user.IsEdit = true;
            user.DateLastEdit = DateTime.Now;
            user.EditedFromIPAddress = model.IPAddress;
            return await UnitOfWork.Users.EditAsync(user);
        }

        public async Task<string> ChangeNames(UserEditNamesModel model)
        {
            var userdb = await UnitOfWork.Users.GetByWhereAsTrackingAsync(d => d.Id == model.Id);
            if (userdb == null)
                return "User by id not found";
            if (!userdb.CanEdit)
                return "Name for edit is lock";
            userdb.Firstname = model.Firstname;
            userdb.Patronymic = model.Patronymic;
            userdb.Lastname = model.Lastname;
            return await UnitOfWork.Users.EditAsync(userdb);
        }

        public async Task<string> ChangeUsername(UserEditUsernameModel model)
        {
            if (await UnitOfWork.Users.IsExistAsync(d => d.Username == model.Username))
                return "Username is not avaliable";
            var user = await UnitOfWork.Users.GetByWhereAsTrackingAsync(d => d.Id == model.Id);
            if (user == null)
                return "User by id not found";
            user.Username = model.Username;
            user.IsEdit = false;
            user.DateLastEdit = DateTime.Now;
            user.LastEditedByUserId = model.UserEditId;
            user.EditedFromIPAddress = model.IPAddress;
            return await UnitOfWork.Users.EditAsync(user);
        }

        public async Task<List<UserShortViewModel>> GetAllStudents()
        {
            var students = await UnitOfWork.Users.GetListByWhereAsync(d => d.UserStatus == UserStatus.Student, e => new User { Id = e.Id, Firstname = e.Firstname, Patronymic = e.Patronymic, Lastname = e.Lastname, Username = e.Username, UserStatus = e.UserStatus, Phone = e.Phone });
            return mapper.Map<List<UserShortViewModel>>(students);
        }

        public async Task<List<UserShortViewModel>> GetAllTeachers()
        {
            var teachers = await UnitOfWork.Users.GetListByWhereAsync(d => d.UserStatus == UserStatus.Teacher, e => new User { Id = e.Id, Firstname = e.Firstname, Patronymic = e.Patronymic, Lastname = e.Lastname, Username = e.Username, UserStatus = e.UserStatus, Phone = e.Phone });
            return mapper.Map<List<UserShortViewModel>>(teachers);
        }

        public async Task<UserViewModel> GetUserById(int Id)
        {
            var userdb = await UnitOfWork.Users.GetByWhereAsync(d => d.Id == Id);
            return mapper.Map<UserViewModel>(userdb);
        }

        public async Task<UserViewModel> GetUserByUsername(string username)
        {
            var userdb = await UnitOfWork.Users.GetByWhereAsync(d => d.Username == username);
            return mapper.Map<UserViewModel>(userdb);
        }

        public async Task<List<UserShortViewModel>> GetUsersByEmail(string email)
        {
            var usersdb = await UnitOfWork.Users.GetListByWhereAsync(d => d.Email == email, e => new User { Id = e.Id, Firstname = e.Firstname, Patronymic = e.Patronymic, Lastname = e.Lastname, Username = e.Username, UserStatus = e.UserStatus, Phone = e.Phone });
            return mapper.Map<List<UserShortViewModel>>(usersdb);
        }

        public async Task<List<UserShortViewModel>> GetUsersByPhone(string phone)
        {
            var usersdb = await UnitOfWork.Users.GetListByWhereAsync(d => d.Phone == phone, e => new User { Id = e.Id, Firstname = e.Firstname, Patronymic = e.Patronymic, Lastname = e.Lastname, Username = e.Username, UserStatus = e.UserStatus, Phone = e.Phone });
            return mapper.Map<List<UserShortViewModel>>(usersdb);
        }

        public async Task<LoginViewModel> LoginUser(AuthViewModel model)
        {
            var user = await UnitOfWork.Users.GetByWhereAsync(d => d.Login == model.Login);
            if (user == null)
                return new LoginViewModel { NotFoundByLogin = true };
            if (!user.IsVerified)
                return new LoginViewModel { AccountNotVerified = true };
            if (!PasswordManager.VerifyPasswordHash(model.Password, user.PasswordHash))
                return new LoginViewModel { InvalidPassword = true };
            return new LoginViewModel
            {
                Id = user.Id,
                Username = user.Username,
                UserStatus = user.UserStatus.ToString(),
                Firstname = user.Firstname,
                Lastname = user.Lastname,
                Role = user.Role.ToString(),
                Photo = user.PhotoPath
            };
        }

        public async Task<string> TestRegisterUser(RegisterViewModel model)
        {
            if (await UnitOfWork.Users.IsExistAsync(d => d.Login == model.Login))
                return "This mail is already taken";
            var user = new User
            {
                Firstname = model.Firstname,
                Patronymic = model.Patronymic,
                Lastname = model.Lastname,
                UserStatus = UserStatus.Student,
                Role = Role.Student,
                CreatedByUserId = model.UserEditId,
                CreatedFromIPAddress = model.IPAddress,
                LinkVerify = Generator.GetString(250),
                Username = Generator.GetString(10),
                Login = model.Login,
                PasswordHash = PasswordManager.GeneratePasswordHash(model.Password),
                IsVerified = true
            };
            return await UnitOfWork.Users.CreateAsync(user);
        }
    }
}