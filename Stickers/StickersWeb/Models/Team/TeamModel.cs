using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DTO.Entities;

namespace StickersWeb.Models.Team
{
    public class TeamModel
    {
        public IEnumerable<UserDto> Users { get; set; }
        public IEnumerable<UserTeamPositionDto> UserTeamPositions { get; set; }
        public IEnumerable<TeamDto> Teams { get; set; }
    }
}