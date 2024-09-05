﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using cafefinder.database;

namespace cafefinder.Pages
{
    public class DeleteModel : PageModel
    {
        private readonly cafefinder.database.DBContext _context;

        public DeleteModel(cafefinder.database.DBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Place Place { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var place = await _context.Places.FirstOrDefaultAsync(m => m.Id == id);

            if (place == null)
            {
                return NotFound();
            }
            else
            {
                Place = place;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var place = await _context.Places.FindAsync(id);
            if (place != null)
            {
                Place = place;
                _context.Places.Remove(Place);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
