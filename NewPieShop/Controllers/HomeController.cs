using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NewPieShop.Models;

namespace NewPieShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository _pieRepository;

        public HomeController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }

        // GET: Home
        public IActionResult Index()
        {
            return View(_pieRepository.GetPies());
        }

        // GET: Home/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pie = _pieRepository.GetPieById(id);
            if (pie == null)
            {
                return NotFound();
            }

            return View(pie);
        }

        // GET: Home/Create
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,Name,ShortDescription,LongDescription,Price,ImageUrl,ThumbnailUrl,IsPieOfTheWeek")] Pie pie)
        {
            if (ModelState.IsValid)
            {
                _pieRepository.AddNewPie(pie);
                return RedirectToAction(nameof(Index));
            }
            return View(pie);
        }

        // GET: Home/Edit/5
        [Authorize]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pie = _pieRepository.GetPieById(id);
            if (pie == null)
            {
                return NotFound();
            }
            return View(pie);
        }

        // POST: Home/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,Name,ShortDescription,LongDescription,Price,ImageUrl,ThumbnailUrl,IsPieOfTheWeek")] Pie pie)
        {
            if (id != pie.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _pieRepository.UpdatePie(pie);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PieExists(pie.Id))
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
            return View(pie);
        }

        // GET: Home/Delete/5
        [Authorize]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pie = _pieRepository.GetPieById(id);
            if (pie == null)
            {
                return NotFound();
            }

            return View(pie);
        }

        // POST: Home/Delete/5
        [Authorize]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var pie = _pieRepository.GetPieById(id);
            _pieRepository.RemovePie(pie);
            return RedirectToAction(nameof(Index));
        }

        private bool PieExists(int id)
        {
            return _pieRepository.GetPieById(id) != null;
        }
    }
}
