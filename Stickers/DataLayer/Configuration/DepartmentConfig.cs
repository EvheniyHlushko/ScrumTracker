using DataLayer.Entities;
using System.Data.Entity.ModelConfiguration;

namespace DataLayer
{
    internal class DepartmentConfig : EntityTypeConfiguration<Department>
    {
        public DepartmentConfig()
        {
            Property(d => d.Name).IsRequired().HasMaxLength(100);
            Property(d => d.Description).HasMaxLength(255);
        }
    }
}