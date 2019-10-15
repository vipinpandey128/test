﻿using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class User
    {
        [Key]
        public long Id { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}
