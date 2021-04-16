﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Dataprossing.Models;
using DataprossingWeb.Data;

namespace DataprossingWeb
{
    public class PopulationAgeGroupInBaishaPenghusController : Controller
    {
        public async Task<IActionResult> Import()
        {
            var filename = @"C:\Users\fuanh\Documents\NKUST-109-2\DataprossingWeb\data.json";
            List<PopulationAgeGroupInBaishaPenghu> populationAgeGroupInBaishaPenghus = await Dataprossing.Models.Repository.readData(filename);
            populationAgeGroupInBaishaPenghus.ForEach(data =>
            {
                _context.PopulationAgeGroupInBaishaPenghus.Add(data);
            });
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        private readonly ApplicationDbContext _context;

        public PopulationAgeGroupInBaishaPenghusController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PopulationAgeGroupInBaishaPenghus
        public async Task<IActionResult> Index()
        {
            await Import();
            return View(await _context.PopulationAgeGroupInBaishaPenghus.ToListAsync());
        }

        // GET: PopulationAgeGroupInBaishaPenghus/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var populationAgeGroupInBaishaPenghu = await _context.PopulationAgeGroupInBaishaPenghus
                .FirstOrDefaultAsync(m => m.Id == id);
            if (populationAgeGroupInBaishaPenghu == null)
            {
                return NotFound();
            }

            return View(populationAgeGroupInBaishaPenghu);
        }

        // GET: PopulationAgeGroupInBaishaPenghus/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PopulationAgeGroupInBaishaPenghus/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,year,month,sum,age0,age1,age2,age3,age4,age5,age6,age7,age8,age9,age10,age11,age12,age13,age14,age15,age16,age17,age18,age19")] PopulationAgeGroupInBaishaPenghu populationAgeGroupInBaishaPenghu)
        {
            if (ModelState.IsValid)
            {
                _context.Add(populationAgeGroupInBaishaPenghu);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(populationAgeGroupInBaishaPenghu);
        }

        // GET: PopulationAgeGroupInBaishaPenghus/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var populationAgeGroupInBaishaPenghu = await _context.PopulationAgeGroupInBaishaPenghus.FindAsync(id);
            if (populationAgeGroupInBaishaPenghu == null)
            {
                return NotFound();
            }
            return View(populationAgeGroupInBaishaPenghu);
        }

        // POST: PopulationAgeGroupInBaishaPenghus/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,year,month,sum,age0,age1,age2,age3,age4,age5,age6,age7,age8,age9,age10,age11,age12,age13,age14,age15,age16,age17,age18,age19")] PopulationAgeGroupInBaishaPenghu populationAgeGroupInBaishaPenghu)
        {
            if (id != populationAgeGroupInBaishaPenghu.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(populationAgeGroupInBaishaPenghu);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PopulationAgeGroupInBaishaPenghuExists(populationAgeGroupInBaishaPenghu.Id))
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
            return View(populationAgeGroupInBaishaPenghu);
        }

        // GET: PopulationAgeGroupInBaishaPenghus/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var populationAgeGroupInBaishaPenghu = await _context.PopulationAgeGroupInBaishaPenghus
                .FirstOrDefaultAsync(m => m.Id == id);
            if (populationAgeGroupInBaishaPenghu == null)
            {
                return NotFound();
            }

            return View(populationAgeGroupInBaishaPenghu);
        }

        // POST: PopulationAgeGroupInBaishaPenghus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var populationAgeGroupInBaishaPenghu = await _context.PopulationAgeGroupInBaishaPenghus.FindAsync(id);
            _context.PopulationAgeGroupInBaishaPenghus.Remove(populationAgeGroupInBaishaPenghu);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PopulationAgeGroupInBaishaPenghuExists(int id)
        {
            return _context.PopulationAgeGroupInBaishaPenghus.Any(e => e.Id == id);
        }
    }
}
