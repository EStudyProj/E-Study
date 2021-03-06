﻿using EStudy.Application.ViewModels;
using EStudy.Application.ViewModels.User;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EStudy.Application.Interfaces.MVC
{
    public interface IUserService
    {
        Task<UserViewModel> GetUserById(int Id);
        Task<UserViewModel> GetUserByUsername(string username);
        Task<List<UserShortViewModel>> GetAllTeachers();
        Task<List<UserShortViewModel>> GetAllStudents();
        Task<List<UserShortViewModel>> GetUsersByEmail(string email);
        Task<List<UserShortViewModel>> GetUsersByPhone(string phone);
        Task<List<UserShortViewModel>> SearchUsers(string name, int count, int offset);
        Task<List<UserShortViewModel>> GetLastUsers();
        Task<string> ChangeUsername(UserEditUsernameModel model);
        Task<string> ChangeNames(UserEditNamesModel model);
        Task<string> ChangeInfo(UserEditInfoModel model);
        Task<string> ChangeDescription(UserEditDescriptionModel model);
        Task<LoginViewModel> LoginUser(AuthViewModel model);
        Task<string> TestRegisterUser(RegisterViewModel model);
        Task<string> RegisterStudent(RegisterViewModel model);
        Task<string> RegisterTeacher(RegisterViewModel model);
        Task<string> ConfirmAccount(UserConfirmModel model);
    }
}