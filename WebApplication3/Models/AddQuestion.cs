using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Model
{
    public class AddQuestion
    {
        public string quiz { get; set; }
        public List<string> choice { get; set; }
        public string cans { get; set; }
        public string QuizID { get; set; }
    }
}
