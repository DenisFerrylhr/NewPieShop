using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewPieShop.Models
{
    public class PieService: IPieRepository
    {
        private readonly NewPieShopContext _context;

        public PieService(NewPieShopContext context)
        {
            _context = context;
        }

        public void AddNewPie(Pie pie)
        {
            _context.Add(pie);
            _context.SaveChangesAsync();
        }

        public Pie GetPieById(int? id)
        {
            var pie = _context.Pie
                .FirstOrDefault(p => p.Id == id);

            return pie;
        }

        public List<Pie> GetPies()
        {
            return _context.Pie.ToList();
        }

        public void RemovePie(Pie pie)
        {
            _context.Pie.Remove(pie);
            _context.SaveChangesAsync();
        }

        public void UpdatePie(Pie pie)
        {
            _context.Update(pie);
            _context.SaveChangesAsync();
        }
    }
}
