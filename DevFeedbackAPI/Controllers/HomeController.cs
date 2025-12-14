using DevFeedbackAPI.Data;
using DevFeedbackAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DevFeedbackAPI.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Home/Index
        public IActionResult Index()
        {
            var developers = _context.Developers.ToList();
            return View(developers);
        }

        // GET: Home/Details/5
        public IActionResult Details(int id)
        {
            var dev = _context.Developers.Include(d => d.Feedbacks).FirstOrDefault(d => d.Id == id);

            if (dev == null) return NotFound();
            return View(dev);
        }

        // GET: Home/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Developer developer)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Developers.Add(developer);
                    _context.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    return Content("ERROR: " + ex.Message);
                }
            }

            // Display model validation errors if any
            var errors = ModelState.Values
                                   .SelectMany(v => v.Errors)
                                   .Select(e => e.ErrorMessage)
                                   .ToList();

            return Content("Invalid: " + string.Join(" | ", errors));
        }

        // GET: Home/Edit/5
        public IActionResult Edit(int id)
        {
            var dev = _context.Developers.Find(id);
            if (dev == null) return NotFound();
            return View(dev);
        }

        // POST: Home/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Developer developer)
        {
            if (id != developer.Id) return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(developer);
                    _context.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    return Content("ERROR: " + ex.Message);
                }
            }
            return View(developer);
        }

        // GET: Home/Delete/5
        public IActionResult Delete(int id)
        {
            var dev = _context.Developers.Find(id);
            if (dev == null) return NotFound();
            return View(dev);
        }

        // POST: Home/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var dev = _context.Developers.Find(id);
            if (dev == null) return NotFound();

            _context.Developers.Remove(dev);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
