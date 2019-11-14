using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class Menu
    {
        [Key]
        public int MenuID { get; set; }
        public string MenuHeader { get; set; }
        public string MenuItem { get; set; }
    }
}