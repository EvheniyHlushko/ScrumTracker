using System.Collections.Generic;
using System.Linq;
using Contracts.IManager;
using DTO.Entities;

namespace BusinessLayer
{
    public class ManagerTeam : BaseManager, IManagerTeam
    {
       
        public IEnumerable<TeamDto> GetAllTeams()
        {
            return _srv.Teams.GetList().ToArray();
        }

        public void AddTeam(TeamDto team)
        {
            _srv.Teams.Add(team);
        }
        public void UpdateTeam(TeamDto team)
        {
            _srv.Teams.Update(team);
        }

        public void RemoveTeam(TeamDto team)
        {
            _srv.Teams.Remove(team);
        }

        public IEnumerable<TeamDto> GetTeamByName(string name)
        {
            var listUsers = _srv.Teams.GetWithFilter(x => x.Name == name).ToArray();
            return listUsers.Length > 0 ? listUsers : null;
        }

       
    }
}
