using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class User
    {
        [Key]
        public long Id { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ProfileImage { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsActive { get; set; }
        public int RoleID { get; set; }

        public virtual Role Role { get; set; }

        public long vID { get; set; }

        public virtual EmailVerification EmailVerification { get; set; }
    }
}
