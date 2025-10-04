using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class OnlineQuizController : Controller
    {
        QuizdbEntities db = new QuizdbEntities();

       
        public ActionResult Index()
        {
            var questions = db.onlineexams.ToList();
            return View(questions); 
        }

        
        [HttpPost]
        public ActionResult SubmitQuiz(FormCollection form)
        {
           
            var results = new List<QuestionResult>();
            var questions = db.onlineexams.ToList();

            foreach (var q in questions)
            {
                var picked = form["q_" + q.Qid];
                var correct = q.Correctans;

                results.Add(new QuestionResult
                {
                    Question = q.Question,
                    UserAnswer = picked,
                    CorrectAnswer = correct,
                    IsCorrect = (picked == correct)
                });
            }

            var model = new QuizResultViewModel
            {
                Results = results,
                Score = results.Count(r => r.IsCorrect),
                TotalQuestions = questions.Count
            };

            return View("Result", model); 
        }
    }
}
