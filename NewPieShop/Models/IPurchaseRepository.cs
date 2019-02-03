using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewPieShop.Models
{
    public interface IPurchaseRepository
    {
        List<Purchase> GetPurchases();
        Purchase GetPurchaseById(int? id);
        void AddNewPurchase(Purchase purchase);
        void UpdatePurchase(Purchase purchase);
        void RemovePurchase(Purchase purchase);
    }
}
