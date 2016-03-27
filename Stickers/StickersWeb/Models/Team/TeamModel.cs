using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DTO.Entities;
using PagedList;

namespace StickersWeb.Models.Team
{
    public class TeamModel
    {
        public IPagedList<UserDto> Users { get; set; }
        public IPagedList<UserTeamPositionDto> UserTeamPositions { get; set; }
        public IPagedList<TeamDto> Teams { get; set; }
    }
}