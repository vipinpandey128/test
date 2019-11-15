using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Blog
    {
        [Key]
        public long BlogId { get; set; }
    
        public string BlogText { get; set; }
        public string BlogImage { get; set; }
        public string BlogTitle { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public long Id { get; set; }
        public virtual User Users { get; set; }
    }
}
