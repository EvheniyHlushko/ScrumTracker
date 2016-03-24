using System.Collections.Generic;

namespace DTO.Entities
{
   public class TeamDto : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<UserTeamPositionDto> UserTeamPositions { get; set; }
        public virtual ICollection<ProjectDto> Projects { get; set; }
    }
}
