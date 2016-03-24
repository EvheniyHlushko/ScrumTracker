using System;

namespace DataLayer.Entities
{
    public class Project : BaseEntity
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }        
        public DateTime DateCreate { get; set; }
        public Guid? StateProjectId { get; set; }
        public Guid? TeamId { get; set; }
        public virtual Team Team { get; set; }
        public virtual StateProject StateProject { get; set; }
    }
}
