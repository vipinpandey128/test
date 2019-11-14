using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class MenuPermission
    {
        [Key]
        public long mPID { get; set; }
        public int MenuID { get; set; }

        public virtual Menu Menu { get; set; }
        public int RoleID { get; set; }

        public virtual Role Role { get; set; }
    }
}
