using DataLayer.Entities;
using System.Data.Entity;
using DataLayer.Configuration;
using Microsoft.AspNet.Identity.EntityFramework;

namespace DataLayer
{
    public partial class StickersContext : IdentityDbContext<User>
    {
        static StickersContext()
        {
            Database.SetInitializer<StickersContext>(new StickersDBInitializer());
        }

        public StickersContext()
            : base("TrackerConnectionString")
        { }

        public virtual DbSet<Department> Departments { get; set; }
        //public virtual DbSet<Role> Roles { get; set; }
        //public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Team> Teams { get; set; }

        public virtual DbSet<Position> Positions { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<StateProject> StateProjects { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new UserConfig());
            //modelBuilder.Configurations.Add(new RoleConfig());
            modelBuilder.Configurations.Add(new DepartmentConfig());
            modelBuilder.Configurations.Add(new ProjectConfig());
            modelBuilder.Configurations.Add(new TeamConfig());
            modelBuilder.Configurations.Add(new UserTeamPositionConfig());

        }

        public static StickersContext Create()
        {
            return new StickersContext();
        }
    }
}
