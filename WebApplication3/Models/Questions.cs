using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Model
{
    public class Questions
    {
        public Questions()
        {
            this.Answers = new HashSet<Answers>();
            this.Choices = new HashSet<Choices>();
        }

        [Key]
        public long QuestionID { get; set; }
        public string QuestionText { get; set; }
        public long QuizID { get; set; }

        public virtual ICollection<Answers> Answers { get; set; }
        public virtual ICollection<Choices> Choices { get; set; }
        public virtual Quiz Quiz { get; set; }
    }
}
