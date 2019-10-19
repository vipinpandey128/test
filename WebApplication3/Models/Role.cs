using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class Role
    {
        public Role()
        {
            this.Users = new HashSet<User>();
        }

        [Key]
        public int RoleID { get; set; }
        public string RoleName { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
