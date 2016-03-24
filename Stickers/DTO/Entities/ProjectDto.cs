using System;

namespace DTO.Entities
{
   public class ProjectDto : BaseEntity
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public System.DateTime DateCreate { get; set; }
        private Guid? StateProjectsId => StateProject?.Id;
        private Guid? TeamId => Team?.Id;
        public virtual StateProjectDto StateProject { get; set; }
        public virtual TeamDto Team { get; set; }
    }
}
