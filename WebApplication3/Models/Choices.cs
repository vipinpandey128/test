using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Model
{
    public class Choices
    {
        [Key]
        public long ChoiceID { get; set; }
        public string ChoiceText { get; set; }
        public long QuestionID { get; set; }

        public virtual Questions Questions { get; set; }
    }
}
