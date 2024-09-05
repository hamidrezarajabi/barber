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
    public class allModel : PageModel
    {
        private readonly cafefinder.database.DBContext _context;

        public allModel(cafefinder.database.DBContext context)
        {
            _context = context;
        }

        public IEnumerable<string?>? N { get; set; }
        public IEnumerable<Place?>? info { get; set; }
        public bool R { get; set; } = false;
        public string? _N { get; set; }
        public bool C { get; set; } = false;
        public bool Fs { get; set; } = false;
        public bool Br { get; set; } = false;
        public bool Roof { get; set; } = false;
        public bool Book { get; set; } = false;
        public bool Faza { get; set; } = false;

        public async Task OnGetAsync(string? n, string? r, string? c, string? fs, string? br, string? roof, string? faza, string? book)
        {
            info = _context.Places;
            N = _context.Places.AsEnumerable().DistinctBy(p => p.Neighborhood).Select(p => p.Neighborhood);
            if (!string.IsNullOrWhiteSpace(n))
            {
                if (n != "همه")
                {
                    info = info.Where(p => p.Neighborhood == n);
                }
                _N = n;
            }
            if (!string.IsNullOrWhiteSpace(r))
            {
                if ((r.ToLower() == "on" || r == "1"))
                {
                    info = info.Where(p => p.Restaurant);
                    R = true;
                }
            }
            if (!string.IsNullOrWhiteSpace(c))
            {
                if ((c.ToLower() == "on" || c == "1"))
                {
                    info = info.Where(p => p.CafeShop);

                    C = true;
                }
            }
            if (!string.IsNullOrWhiteSpace(fs))
            {
                if ((fs.ToLower() == "on" || fs == "1"))
                {
                    info = info.Where(p => p.FreeSmoke);
                    Fs = true;
                }
            }

            if (!string.IsNullOrWhiteSpace(br))
            {
                if ((br.ToLower() == "on" || br == "1"))
                {
                    info = info.Where(p => p.BirthdayTheme);
                    Br = true;
                }
            }
            if (!string.IsNullOrWhiteSpace(roof))
            {
                if ((roof.ToLower() == "on" || roof == "1"))
                {
                    info = info.Where(p => p.RoofGarden);
                    Roof = true;
                }
            }
            if (!string.IsNullOrWhiteSpace(book))
            {
                if ((book.ToLower() == "on" || book == "1"))
                {
                    info = info.Where(p => p.BookCafe);
                    Book = true;
                }
            }

            if (!string.IsNullOrWhiteSpace(faza))
            {
                if ((faza.ToLower() == "on" || faza == "1"))
                {
                    info = info.Where(p => p.OpenSpace);
                    Faza = true;
                }
            }




        }
    }
}
