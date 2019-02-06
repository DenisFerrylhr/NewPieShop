using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NewPieShop.Models;

namespace NewPieShop.Controllers
{
    public class FeedbacksController : Controller
    {
        private readonly IFeedbackRepository _feedbackRepository;

        public FeedbacksController(IFeedbackRepository feedbackRepository)
        {
            _feedbackRepository = feedbackRepository;
        }

        // GET: Feedbacks
        public IActionResult Index()
        {
            return View(_feedbackRepository.GetFeedbacks());
        }

        // GET: Feedbacks/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var feedback = _feedbackRepository.GetFeedbackById(id);
            if (feedback == null)
            {
                return NotFound();
            }

            return View(feedback);
        }

        // GET: Feedbacks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Feedbacks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,Name,Email,Message,Contact")] Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                _feedbackRepository.AddNewFeedback(feedback);
                return RedirectToAction(nameof(Index));
            }
            return View(feedback);
        }

        // GET: Feedbacks/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var feedback = _feedbackRepository.GetFeedbackById(id);
            if (feedback == null)
            {
                return NotFound();
            }

            return View(feedback);
        }

        // POST: Feedbacks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var feedback = _feedbackRepository.GetFeedbackById(id);
            _feedbackRepository.RemoveFeedback(feedback);
            return RedirectToAction(nameof(Index));
        }

        private bool FeedbackExists(int id)
        {
            return _feedbackRepository.GetFeedbackById(id) != null;
        }
    }
}
