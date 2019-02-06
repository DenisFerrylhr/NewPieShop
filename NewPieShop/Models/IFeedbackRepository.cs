using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewPieShop.Models
{
    public interface IFeedbackRepository
    {
        List<Feedback> GetFeedbacks();
        Feedback GetFeedbackById(int? id);
        void AddNewFeedback(Feedback feedback);
        void RemoveFeedback(Feedback feedback);
    }
}
