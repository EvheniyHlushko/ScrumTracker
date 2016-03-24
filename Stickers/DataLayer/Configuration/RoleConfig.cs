using DataLayer.Entities;
using System.Data.Entity.ModelConfiguration;

namespace DataLayer
{
    internal class RoleConfig : EntityTypeConfiguration<Role>
    {
        public RoleConfig()
        {
            ToTable("Roles");
        }
    }
}