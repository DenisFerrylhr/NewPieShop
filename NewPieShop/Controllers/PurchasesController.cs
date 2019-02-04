using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NewPieShop.Models;
using NewPieShop.ModelViews;

namespace NewPieShop.Controllers
{
    public class PurchasesController : Controller
    {
        private readonly IPurchaseRepository _purchaseRepository;
        private readonly IPieRepository _pieRepository;
        private readonly ICustomerRepository _customerRepository;

        public PurchasesController(IPurchaseRepository purchaseRepository, IPieRepository pieRepository, ICustomerRepository customerRepository)
        {
            _purchaseRepository = purchaseRepository;
            _pieRepository = pieRepository;
            _customerRepository = customerRepository;
        }

        // GET: Purchases
        public IActionResult Index()
        {
            return View(_purchaseRepository.GetPurchases());
        }

        // GET: Purchases/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var purchase = _purchaseRepository.GetPurchaseById(id);
            PieCustomer pieCustomer = new PieCustomer
            {
                Pie = _pieRepository.GetPieById(purchase.PieId),
                Customer = _customerRepository.GetCustomerById(purchase.CustomerId)
            };

            if (purchase == null)
            {
                return NotFound();
            }

            return View(purchase);
        }

        // GET: Purchases/Create
        public IActionResult Create()
        {
            ViewData["PieId"] = new SelectList(_pieRepository.GetPies(), "Id", "Name");
            ViewData["CustomerId"] = new SelectList(_customerRepository.GetCustomers(), "Id", "Name");
            return View();
        }

        // POST: Purchases/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,PieId,CustomerId")] Purchase purchase)
        {
            if (ModelState.IsValid)
            {
                _purchaseRepository.AddNewPurchase(purchase);
                return RedirectToAction(nameof(Index));
            }
            return View(purchase);
        }

        // GET: Purchases/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var purchase = _purchaseRepository.GetPurchaseById(id);
            if (purchase == null)
            {
                return NotFound();
            }
            return View(purchase);
        }

        // POST: Purchases/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,PieId,CustomerId")] Purchase purchase)
        {
            if (id != purchase.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _purchaseRepository.UpdatePurchase(purchase);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PurchaseExists(purchase.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(purchase);
        }

        // GET: Purchases/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var purchase = _purchaseRepository.GetPurchaseById(id);
            if (purchase == null)
            {
                return NotFound();
            }

            return View(purchase);
        }

        // POST: Purchases/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var purchase = _purchaseRepository.GetPurchaseById(id);
            _purchaseRepository.RemovePurchase(purchase);
            return RedirectToAction(nameof(Index));
        }

        private bool PurchaseExists(int id)
        {
            return _purchaseRepository.GetPurchaseById(id) != null;
        }
    }
}
