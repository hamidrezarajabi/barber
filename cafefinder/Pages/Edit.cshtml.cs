using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using cafefinder.database;
using System.IO;

namespace cafefinder.Pages
{
    public class EditModel : PageModel
    {
        private readonly cafefinder.database.DBContext _context;

        public EditModel(cafefinder.database.DBContext context)
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

            var place =  await _context.Places.FirstOrDefaultAsync(m => m.Id == id);
            if (place == null)
            {
                return NotFound();
            }
            Place = place;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync( )
        {
            Console.WriteLine(HttpContext.Request.Form.Files);
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var exist= _context.Places.Find( Place.Id);
            if (exist == null)
            {
                return NotFound();
            }
            List<KeyValuePair<string, string>>? files = new();
            foreach (var file in HttpContext.Request.Form.Files)
            {
                var _ = file;

                using (var memoryStream = new MemoryStream())
                {
                    file.CopyTo(memoryStream);
                    var filekv = new KeyValuePair<string, string>(file.FileName, Convert.ToBase64String(memoryStream.ToArray()));
                    files.Add(filekv);
                }


            }
            Place.Photo = files;
            _context.Places.Update(Place);
            _context.SaveChanges();

            return RedirectToPage("./Index");
        }

        private bool PlaceExists(Guid id)
        {
            return _context.Places.Any(e => e.Id == id);
        }
    }
}
