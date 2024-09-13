using cafefinder.database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace cafefinder.Pages
{
    public class cafepanelModel : PageModel
    {

        private readonly cafefinder.database.DBContext _context;

        public cafepanelModel(cafefinder.database.DBContext context)
        {
            _context = context;
        }

        public Place? Place { get; set; } = default!;

        public IActionResult OnGet()
        {

            var users = _context.Places.Where(p => p.UserName == HttpContext.Request.Cookies["username"] && p.Password == HttpContext.Request.Cookies["password"]);
            if (!users.Any())
            {

                return RedirectToPage("login");
            }
            Place = users.FirstOrDefault();



            return Page();
        }


        public async Task<IActionResult> OnPostAsync(string? addtime, string? deleteTime, string? clearTime)
        {
            var users = _context.Places.Where(p => p.UserName == HttpContext.Request.Cookies["username"] && p.Password == HttpContext.Request.Cookies["password"]);
            if (!users.Any())
            {

                return RedirectToPage("login");
            }
            Place = users.FirstOrDefault();

            if (!string.IsNullOrWhiteSpace(addtime))
            {

                if (!Place.rezerv.Contains(addtime))
                {
                    Place.rezerv.Add(addtime);
                    _context.Places.Update(Place);
                    _context.SaveChanges();
                }

            }
            if (!string.IsNullOrWhiteSpace(deleteTime))
            {

                if (Place.rezerv.Contains(deleteTime))
                {
                    Place.rezerv.Remove(deleteTime);
                    _context.Places.Update(Place);
                    _context.SaveChanges();
                }

            }
            if (!string.IsNullOrWhiteSpace(clearTime))
            {


                Place.selectrezerv.Remove(clearTime);
                _context.Places.Update(Place);
                _context.SaveChanges();

            }
            return Page();
        }


    }
}
