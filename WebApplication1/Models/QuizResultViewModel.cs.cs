using System.Collections.Generic;

namespace WebApplication1.Models
{
    public class QuizResultViewModel
    {
        public int Score { get; set; }                 
        public int TotalQuestions { get; set; }        
        public List<QuestionResult> Results { get; set; } 
    }

    public class QuestionResult
    {
        public string Question { get; set; }
        public string UserAnswer { get; set; }
        public string CorrectAnswer { get; set; }
        public bool IsCorrect { get; set; }
    }
}
