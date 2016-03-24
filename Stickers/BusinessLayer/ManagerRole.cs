using System;
using System.Collections.Generic;
using System.Linq;
using Contracts.IManager;
using DTO.Entities;

namespace BusinessLayer
{
    public class ManagerRole:BaseManager, IManagerRole
    {
        public IEnumerable<RoleDto> GetAllRoles()
        {
            return _srv.Roles.GetList().ToArray();
        }

        public void AddRole(RoleDto role)
        {
            _srv.Roles.Add(role);
        }

        public void RemoveRole(RoleDto role)
        {
            _srv.Roles.Remove(role);
        }

        public IEnumerable<RoleDto> GetRoleByName(String name)
        {
            var listRole = _srv.Roles.GetWithFilter(x => x.Name == name).ToArray();
            return listRole.Length > 0 ? listRole : null;
        }

    }
}
