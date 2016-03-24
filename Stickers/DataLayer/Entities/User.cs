using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace DataLayer.Entities
{
    public class User : IdentityUser
    {
        public User()
        {
            UserTeamPositions = new HashSet<UserTeamPosition>();
        }
       public string LastName { get; set; }
        public string Firstname { get; set; }
        public string Avatar { get; set; }
        public Guid? DepartmentId { get; set; }
        public virtual Department Department { get; set; }
        public virtual ICollection<UserTeamPosition> UserTeamPositions { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User> manager)
        {
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            return userIdentity;
        }
    }
}

