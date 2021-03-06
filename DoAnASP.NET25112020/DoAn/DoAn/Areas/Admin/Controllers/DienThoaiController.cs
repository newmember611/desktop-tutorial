﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DoAn.Areas.Admin.Data;
using DoAn.Areas.Admin.Models;

namespace DoAn.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DienThoaiController : Controller
    {
        private readonly DPContext _context;

        public DienThoaiController(DPContext context)
        {
            _context = context;
        }

        // GET: Admin/DienThoai
        public async Task<IActionResult> Index()
        {
            return View(await _context.DienThoai.ToListAsync());
        }

        // GET: Admin/DienThoai/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dienThoaiModel = await _context.DienThoai
                .FirstOrDefaultAsync(m => m.MaDongDT == id);
            if (dienThoaiModel == null)
            {
                return NotFound();
            }

            return View(dienThoaiModel);
        }

        // GET: Admin/DienThoai/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/DienThoai/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaDongDT,MaLoai,MaHangSX,MaNCC,TenDongDT,Hinh,DonGia,GiaKM")] DienThoaiModel dienThoaiModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dienThoaiModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dienThoaiModel);
        }

        // GET: Admin/DienThoai/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dienThoaiModel = await _context.DienThoai.FindAsync(id);
            if (dienThoaiModel == null)
            {
                return NotFound();
            }
            return View(dienThoaiModel);
        }

        // POST: Admin/DienThoai/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("MaDongDT,MaLoai,MaHangSX,MaNCC,TenDongDT,Hinh,DonGia,GiaKM")] DienThoaiModel dienThoaiModel)
        {
            if (id != dienThoaiModel.MaDongDT)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dienThoaiModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DienThoaiModelExists(dienThoaiModel.MaDongDT))
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
            return View(dienThoaiModel);
        }

        // GET: Admin/DienThoai/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dienThoaiModel = await _context.DienThoai
                .FirstOrDefaultAsync(m => m.MaDongDT == id);
            if (dienThoaiModel == null)
            {
                return NotFound();
            }

            return View(dienThoaiModel);
        }

        // POST: Admin/DienThoai/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var dienThoaiModel = await _context.DienThoai.FindAsync(id);
            _context.DienThoai.Remove(dienThoaiModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DienThoaiModelExists(string id)
        {
            return _context.DienThoai.Any(e => e.MaDongDT == id);
        }
    }
}
