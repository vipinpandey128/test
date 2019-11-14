using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class UserProfile
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string ProfileImage { get; set; }
        public bool IsActive { get; set; }
        public string RoleName { get; set; }
        public List<Menu> Menu { get; set; }
    }
}
