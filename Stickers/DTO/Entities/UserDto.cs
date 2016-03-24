using System;
using System.Collections.Generic;

namespace DTO.Entities
{
    public class UserDto 
    {
        public string Id { get; set; }
        public string Login { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string Lastname { get; set; }

        public string Firstname { get; set; }

        public string Avatar { get; set; }
        public bool JustRegistered { get; set; }
        public DepartmentDto Department { get; set; }

        public RoleDto Role { get; set; }
        private Guid? DepartmentId => Department?.Id;

        private Guid? RoleId => Role?.Id;
        //private Guid? RoleId {
        //    get
        //    {
        //        if (Role.Id != null)
        //            return Role.Id;
        //        return null;
        //    }
        //}

        public virtual ICollection<UserTeamPositionDto> UserTeamPositions { get; set; }
    }
}
