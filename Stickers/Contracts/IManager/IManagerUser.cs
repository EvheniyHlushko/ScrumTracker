using System;
using System.Collections.Generic;
using DTO.Entities;

namespace Contracts.IManager
{
    public interface IManagerUser
    {
        void AddUser(UserDto user);
        void RemoveUser(UserDto user);
        void UpdateUser(UserDto user);
        IEnumerable<UserDto> GetAllUsers();
        IEnumerable<UserDto> GetUsersByEmail(String email);
        UserDto Authenticate(string login, string password);
        void Registration(UserDto user);
        void SetPassword(UserDto user);
    }
}