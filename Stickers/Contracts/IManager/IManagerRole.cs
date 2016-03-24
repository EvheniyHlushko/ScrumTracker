using System;
using System.Collections.Generic;
using DTO.Entities;

namespace Contracts.IManager
{
    public interface IManagerRole
    {
        IEnumerable<RoleDto> GetAllRoles();
        void AddRole(RoleDto role);
        void RemoveRole(RoleDto role);
        IEnumerable<RoleDto> GetRoleByName(String name);
    }
}