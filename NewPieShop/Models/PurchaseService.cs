using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewPieShop.Models
{
    public class PurchaseService : IPurchaseRepository
    {
        private readonly NewPieShopContext _context;

        public PurchaseService(NewPieShopContext context)
        {
            _context = context;
        }

        public void AddNewPurchase(Purchase purchase)
        {
            _context.Add(purchase);
            _context.SaveChanges();
        }

        public Purchase GetPurchaseById(int? id)
        {
            var purchase = _context.Purchase
                .FirstOrDefault(p => p.Id == id);

            return purchase;
        }

        public List<Purchase> GetPurchases()
        {
            return _context.Purchase.ToList();
        }

        public void RemovePurchase(Purchase purchase)
        {
            _context.Purchase.Remove(purchase);
            _context.SaveChanges();
        }

        public void UpdatePurchase(Purchase purchase)
        {
            _context.Update(purchase);
            _context.SaveChanges();
        }
    }
}
