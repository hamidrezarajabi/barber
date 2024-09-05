using cafefinder.database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace cafefinder.Pages
{
    public class searchModel : PageModel
    {
        private readonly cafefinder.database.DBContext _context;
        public List<Place> BYS { get; set; } = new List<Place>();
        public string s;
        public searchModel(cafefinder.database.DBContext context)
        {
            _context = context;
        }
        public async Task OnGetAsync(string? s)
        {
            this.s = s;
            var l = _context.Places.AsEnumerable();
            if (!string.IsNullOrWhiteSpace(s))
                BYS = l?.Where(p => p.Name.Contains(s) || p.Address.Contains(s)).ToList();

        }
    }
}
