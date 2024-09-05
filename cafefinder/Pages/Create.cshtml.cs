using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using cafefinder.database;

namespace cafefinder.Pages
{
    public class CreateModel : PageModel
    {
        private readonly cafefinder.database.DBContext _context;

        public CreateModel(cafefinder.database.DBContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Place Place { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {



            if (!ModelState.IsValid)
            {
                return Page();
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
            _context.Places.Add(Place);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
