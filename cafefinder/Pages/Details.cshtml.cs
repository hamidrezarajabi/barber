using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using cafefinder.database;

namespace cafefinder.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly cafefinder.database.DBContext _context;

        public DetailsModel(cafefinder.database.DBContext context)
        {
            _context = context;
        }

        public Place Place { get; set; } = default!;
        public bool IsLogin { get; set; }= false;
        [HttpGet]
        public async Task<IActionResult> OnGetAsync(Guid? id )
        {
            Id = id;
            if (_context.Users.Where(p => p.UserName == HttpContext.Request.Cookies["username"] && p.Password == HttpContext.Request.Cookies["password"]).Any())
            {
                IsLogin = true;
            }

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
        [HttpPost]
        public async Task<IActionResult> OnPostAsync(Guid? id)
        {
            Id= id;
            if (_context.Users.Where(p => p.UserName == HttpContext.Request.Cookies["username"] && p.Password == HttpContext.Request.Cookies["password"]).Any())
            {
                IsLogin = true;
            }


            if (HttpContext.Request.Form.ContainsKey("text") && HttpContext.Request.Form.ContainsKey("rate"))
            {
                if (!float.TryParse(HttpContext.Request.Form["rate"], out float r))
                    return Page();
                var f = _context.Places.Find(id);
                if (f == null)
                    return NotFound();
                f.StarRating.Add(new(HttpContext.Request.Form["text"], r));
                _context.Places.Update(f);
                _context.SaveChanges();
                Place = f;
            }   

            return Page();
        }

        public Guid? Id { get; set; }


    }
}
