using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Model
{
    public class Answers
    {
        [Key]
        public long AnswerID { get; set; }
        public string AnswerText { get; set; }
        public long QuestionID { get; set; }

        public virtual Questions Questions { get; set; }
    }
}
