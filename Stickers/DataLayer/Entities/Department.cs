using System.Collections.Generic;
namespace DataLayer.Entities
{
    public class Department : BaseEntity
    {
        public Department()
        {
            Users = new HashSet<User>();
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
