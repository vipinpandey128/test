using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Controllers
{
    public class EmailVerification
    {
        public long vID { get; set; }
        public string vLink { get; set; }
        public long vUserId { get; set; }
        public bool vIsStatus { get; set; }
    }
}
