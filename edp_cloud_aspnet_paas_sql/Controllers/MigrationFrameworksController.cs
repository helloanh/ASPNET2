using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EFGetStarted.AspNetCore.ExistingDb.Models;

namespace EFGetStarted.AspNetCore.ExistingDb.Controllers
{
    public class MigrationFrameworksController : Controller
    {
        private readonly BloggingContext _context;

        public MigrationFrameworksController(BloggingContext context)
        {
            _context = context;
        }

        // GET: MigrationFrameworks
        public async Task<IActionResult> Index()
        {
            return View(await _context.MigrationFramework.ToListAsync());
        }

        // GET: MigrationFrameworks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blog = await _context.MigrationFramework
                .FirstOrDefaultAsync(m => m.MigrationFrameworkId == id);
            if (blog == null)
            {
                return NotFound();
            }

            return View(blog);
        }
 

    }
}

