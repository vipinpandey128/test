using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class EmailVerification
    {
        [Key]
        public long vID { get; set; }
        public string vLink { get; set; }
        public long vUserId { get; set; }
        public bool vIsStatus { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
