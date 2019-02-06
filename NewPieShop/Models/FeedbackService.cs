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

        public void AddNew(Feedback feedback)
        {
            _context.Add(feedback);
            _context.SaveChanges();
        }
    }
}
