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
    public class IndexModel : PageModel
    {
        private readonly cafefinder.database.DBContext _context;

        public IndexModel(cafefinder.database.DBContext context)
        {
            _context = context;
        }

        public List<Place> Top { get; set; }
        public List<Place> BYN { get; set; }= new List<Place>();
        public List<string?>? N { get; set; }
        public async Task OnGetAsync(string? n)
        {
           
            var l = _context.Places.AsEnumerable();
            if (string.IsNullOrWhiteSpace(n))
                n=l.FirstOrDefault().Neighborhood;

                Top = l.OrderBy(p =>
            {
                var star = 0f;
                foreach (var item in p.StarRating.Select(prop => prop.Value))
                {
                    star += item;
                }
                return star;
            }).ToList();
            N = l?.AsEnumerable().DistinctBy((p) => p.Neighborhood)?.Select(p => p.Neighborhood).Take(4).ToList();
                BYN = l?.Where(p => p.Neighborhood == n).ToList();


        }
    }
}
