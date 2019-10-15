using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Model
{
    public class Quiz
    {
       
        public Quiz()
        {
            this.Questions = new HashSet<Questions>();
        }

        [Key]
        public long QuizID { get; set; }
        public string QuizName { get; set; }
        public string QuizImage { get; set; }
        public string Route { get; set; }
        public virtual ICollection<Questions> Questions { get; set; }
    }
}
