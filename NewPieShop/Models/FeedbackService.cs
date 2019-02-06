using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewPieShop.Models
{
    public class FeedbackService : IFeedbackRepository
    {
        private readonly NewPieShopContext _context;

        public FeedbackService(NewPieShopContext context)
        {
            _context = context;
        }

        public void AddNewFeedback(Feedback feedback)
        {
            _context.Add(feedback);
            _context.SaveChanges();
        }

        public Feedback GetFeedbackById(int? id)
        {
            var feedback = _context.Feedback
                .FirstOrDefault(p => p.Id == id);

            return feedback;
        }

        public List<Feedback> GetFeedbacks()
        {
            return _context.Feedback.ToList();
        }

        public void RemoveFeedback(Feedback feedback)
        {
            _context.Feedback.Remove(feedback);
            _context.SaveChanges();
        }
    }
}
