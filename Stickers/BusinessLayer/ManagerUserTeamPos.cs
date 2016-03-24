using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts.IManager;
using DTO.Entities;

namespace BusinessLayer
{
    public class ManagerUserTeamPos: BaseManager,IManagerUserTeamPos
    {
        public IEnumerable<UserTeamPositionDto> GetAllUserTeamPos()
        {
            return _srv.UserTeamPositions.GetList().ToArray();
        }
        public void UpdateUserTeamPos(UserTeamPositionDto teamPos)
        {
            _srv.UserTeamPositions.Update(teamPos);
        }
        public void RemoveUserTeamPos(UserTeamPositionDto userTeamPos)
        {
            _srv.UserTeamPositions.Remove(userTeamPos);
        }
        public void AddUserTeamPos(UserTeamPositionDto team)
        {
            _srv.UserTeamPositions.Add(team);
        }
        public IEnumerable<UserTeamPositionDto> GetUsersInTeam(UserTeamPositionDto item)
        {
            var listUsers = _srv.UserTeamPositions.GetWithFilter(x => x.TeamId == item.TeamId && x.UserId == item.UserId).ToArray();
            return listUsers.Length > 0 ? listUsers : null;
        }
    }
}
