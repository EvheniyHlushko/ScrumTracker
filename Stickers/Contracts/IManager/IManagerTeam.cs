using System.Collections.Generic;
using DTO.Entities;

namespace Contracts.IManager
{
    public interface IManagerTeam
    {
        IEnumerable<TeamDto> GetAllTeams();
        void AddTeam(TeamDto team);
        void UpdateTeam(TeamDto team);
        void RemoveTeam(TeamDto team);
        IEnumerable<TeamDto> GetTeamByName(string name);
    }
}