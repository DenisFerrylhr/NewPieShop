using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewPieShop.Models
{
    public interface IPieRepository
    {
        List<Pie> GetPies();
        Pie GetPieById(int? id);
        void AddNewPie(Pie pie);
        void UpdatePie(Pie pie);
        void RemovePie(Pie pie);
    }
}
