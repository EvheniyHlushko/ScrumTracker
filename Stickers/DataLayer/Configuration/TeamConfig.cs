using System.Data.Entity.ModelConfiguration;
using DataLayer.Entities;

namespace DataLayer.Configuration
{
    public class TeamConfig : EntityTypeConfiguration<Team>
    {
        public TeamConfig()
        {
            HasKey(t => t.Id);    

            Property(p => p.Name).IsRequired().HasMaxLength(50);
            Property(p => p.Description).IsRequired().HasMaxLength(200);
        }
    }
}
