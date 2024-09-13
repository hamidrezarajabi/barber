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
        public bool _man { get; set; } = false;
        public string? _N { get; set; }
        public bool _women { get; set; } = false;
        public bool _damadarosgrim { get; set; } = false;
        public bool _paksazisorat { get; set; } = false;
        public bool _keratin { get; set; } = false;
        public bool _feshial { get; set; } = false;
        public bool _kashtnakhon { get; set; } = false;
        public bool _childeren { get; set; } = false;
        public async Task OnGetAsync(string? n, string? man, string? women, string? damadarosgrim, string? paksazisorat, string? keratin, string? feshial, string? kashtnakhon, string? childeren)
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
            if (!string.IsNullOrWhiteSpace(man))
            {
                if ((man.ToLower() == "on" || man == "1"))
                {
                    info = info.Where(p => p.Man);
                    _man = true;
                }
            }
            if (!string.IsNullOrWhiteSpace(women))
            {
                if ((women.ToLower() == "on" || women == "1"))
                {
                    info = info.Where(p => p.Women);

                    _women = true;
                }
            }
            if (!string.IsNullOrWhiteSpace(damadarosgrim))
            {
                if ((damadarosgrim.ToLower() == "on" || damadarosgrim == "1"))
                {
                    info = info.Where(p => p.DamadArosGrim);
                    _damadarosgrim = true;
                }
            }

            if (!string.IsNullOrWhiteSpace(paksazisorat))
            {
                if ((paksazisorat.ToLower() == "on" || paksazisorat == "1"))
                {
                    info = info.Where(p => p.PaksaziSorat);
                    _paksazisorat = true;
                }
            }
            if (!string.IsNullOrWhiteSpace(keratin))
            {
                if ((keratin.ToLower() == "on" || keratin == "1"))
                {
                    info = info.Where(p => p.keratin);
                    _keratin = true;
                }
            }
            if (!string.IsNullOrWhiteSpace(feshial))
            {
                if ((feshial.ToLower() == "on" || feshial == "1"))
                {
                    info = info.Where(p => p.feshial);
                    _feshial = true;
                }
            }

            if (!string.IsNullOrWhiteSpace(kashtnakhon))
            {
                if ((kashtnakhon.ToLower() == "on" || kashtnakhon == "1"))
                {
                    info = info.Where(p => p.kashtnakhon);
                    _kashtnakhon = true;
                }
            }
            if (!string.IsNullOrWhiteSpace(childeren))
            {
                if ((childeren.ToLower() == "on" || childeren == "1"))
                {
                    info = info.Where(p => p.Childeren);
                    _childeren = true;
                }
            }




        }
    }
}
