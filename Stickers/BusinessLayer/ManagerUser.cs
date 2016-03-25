using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Contracts.IManager;
using DTO.Entities;

namespace BusinessLayer
{

    public class ManagerUser : BaseManager, IManagerUser
    {
        public void AddUser(UserDto user)
        {
            _srv.Users.Add(user);
        }

        public void RemoveUser(UserDto user)
        {
            _srv.Users.Remove(user);
        }

        public void UpdateUser(UserDto user)
        {
            _srv.Users.Update(user);
        }

        public IEnumerable<UserDto> GetAllUsers()
        {
            return _srv.Users.GetList().ToArray();
        }

        public IEnumerable<UserDto> GetUsersByEmail(String email)
        {
            var listusers = _srv.Users.GetWithFilter(x => x.Email == email).ToArray();
            return listusers.Length > 0 ? listusers : null;
        }

        public UserDto Authenticate(string login, string password)
        {
            throw new NotImplementedException();
        }

        private string CalculateHash(string password, string salt)
        {
            byte[] saltedHashBytes = Encoding.UTF8.GetBytes(password + salt);
            HashAlgorithm algorithm = new SHA256Managed();
            byte[] hash = algorithm.ComputeHash(saltedHashBytes);
            return Convert.ToBase64String(hash);
        }

        //public UserDto Authenticate(string login, string password)
        //{
        //    password = CalculateHash(password, login);
        //    var usersData = _srv.Users.GetWithFilter(x => x.Login == login && x.Password == password).ToArray();
        //    if (usersData.Length > 0)
        //        return usersData.First();
        //    return null;

        //}

        //public void Registration(UserDto user)
        //{
        //    user.Password = CalculateHash(user.Password, user.Login);
        //    AddUser(user);
        //}

        //public void SetPassword(UserDto user)
        //{
        //    user.Password = CalculateHash(user.Password, user.Login);
        //    UpdateUser(user);
        //}
    }
}
