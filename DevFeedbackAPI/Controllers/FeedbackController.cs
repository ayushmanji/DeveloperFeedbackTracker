using DevFeedbackAPI.Data;
using DevFeedbackAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DevFeedbackAPI.Controllers
{
    public class FeedbackController : Controller
    {
        private readonly AppDbContext _context;

        public FeedbackController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Feedback/Create?developerId=1
        public IActionResult Create(int developerId)
        {
            ViewBag.DeveloperId = developerId;
            return View(new Feedback { DeveloperId = developerId });
        }




        // POST: Feedback/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                feedback.CreatedAt = DateTime.Now;
                _context.Feedbacks.Add(feedback);
                _context.SaveChanges();
                return RedirectToAction("Details", "Home", new { id = feedback.DeveloperId });
            }

            ViewBag.DeveloperId = feedback.DeveloperId;
            return View(feedback);
        }
    }
}
