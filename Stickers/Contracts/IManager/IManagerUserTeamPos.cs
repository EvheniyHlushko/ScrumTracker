using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Entities;

namespace Contracts.IManager
{
  public interface IManagerUserTeamPos
    {
        IEnumerable<UserTeamPositionDto> GetAllUserTeamPos();
        void RemoveUserTeamPos(UserTeamPositionDto userTeamPos);
        void AddUserTeamPos(UserTeamPositionDto team);
        void UpdateUserTeamPos(UserTeamPositionDto teamPos);
        IEnumerable<UserTeamPositionDto> GetUsersInTeam(UserTeamPositionDto item);
    }
}
