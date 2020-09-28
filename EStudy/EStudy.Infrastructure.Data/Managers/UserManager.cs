using EStudy.Domain.Models;
using EStudy.Infrastructure.Data.Context;
using Extensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStudy.Infrastructure.Data.Managers
{
    public class UserManager
    {
        static UserManager manager;
        private EStudyContext db;
        private User user;
        private UserManager(int Id)
        {
            db = new EStudyContext();
            user = db.Users.FindAsync(Id).GetAwaiter().GetResult();
            if (user == null)
                throw new Exception("User not found");
        }

        public static UserManager GetInstance(int Id)
        {
            if (manager == null)
                manager = new UserManager(Id);
            return manager;
        }

        public User GetCurrentUser()
        {
            return user;
        }

        public string GetRoleUser()
        {
            return user.Role.ToString();
        }

        public string GetUserStatus()
        {
            return user.UserStatus.ToString();
        }

        public string GetPasswordHash()
        {
            return user.PasswordHash;
        }

        public string GetLogin()
        {
            return user.Login;
        }

        public string GetUsername()
        {
            return user.Username;
        }

        public string[] GetNames()
        {
            return new string[] { user.Firstname, user.Patronymic, user.Lastname };
        }

        public async System.Threading.Tasks.Task SaveUserAsync()
        {
            db.Users.Update(user);
            await db.SaveChangesAsync().ConfigureAwait(false);
        }

        public async void ChangeUsername(string username)
        {
            if (await db.Users.AsNoTracking().Select(d => new User { Id = d.Id, Username = d.Username }).FirstOrDefaultAsync(d => d.Username == username) != null)
                throw new Exception("This username is already exist");
            user.Username = username;
        }

        public bool VerifyPassword(string password)
        {
            if (!PasswordManager.VerifyPasswordHash(password, user.PasswordHash))
                return false;
            return true;
        }

        public void ChangePassword(string oldPassword, string newPassword)
        {
            if (!VerifyPassword(oldPassword))
                throw new Exception("Your password not valid");
            user.PasswordHash = PasswordManager.GeneratePasswordHash(newPassword);
        }

        public async void ChangeLogin(string login)
        {
            if (await db.Users.AsNoTracking().Select(d => new User { Id = d.Id, Login = d.Login }).FirstOrDefaultAsync(d => d.Login == login) != null)
                throw new Exception("This login is already exist");
            user.Login = login;
        }
    }
}