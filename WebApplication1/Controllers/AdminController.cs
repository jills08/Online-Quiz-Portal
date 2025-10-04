using System.Linq;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class AdminController : Controller
    {
        QuizdbEntities db = new QuizdbEntities();

        // GET: Admin/Index
        public ActionResult Index()
        {
            var questions = db.onlineexams.ToList();
            return View(questions);
        }

        // GET: Admin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(onlineexam model)
        {
            if (ModelState.IsValid)
            {
                db.onlineexams.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        // GET: Admin/Edit/5
        public ActionResult Edit(int id)
        {
            var question = db.onlineexams.Find(id);
            if (question == null)
                return HttpNotFound();

            return View(question);
        }

        // POST: Admin/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(onlineexam model)
        {
            if (ModelState.IsValid)
            {
                db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        // GET: Admin/Delete/5
        public ActionResult Delete(int id)
        {
            var question = db.onlineexams.Find(id);
            if (question == null)
                return HttpNotFound();

            return View(question);
        }

        // POST: Admin/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var question = db.onlineexams.Find(id);
            if (question == null)
                return HttpNotFound();

            db.onlineexams.Remove(question);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
