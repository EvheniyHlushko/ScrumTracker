using System.Collections.Generic;

namespace DTO.Entities
{
    public class RoleDto:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<UserDto> Users { get; set; }
    }
}
