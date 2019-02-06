using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewPieShop.Models
{
    public interface IFeedbackRepository
    {
        void AddNew(Feedback feedback);
    }
}
