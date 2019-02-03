using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewPieShop.Models
{
    interface IPieRepository
    {
        List<Pie> GetPies();
        Pie GetPieById(int? id);
        void AddNewPie();
        void RemovePie(int? id);
    }
}
