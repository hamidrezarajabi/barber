using cafefinder.database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace cafefinder.Pages
{
    public class loginModel : PageModel
    {

        public loginModel(DBContext DBlogin)
        {
            DBcontext = DBlogin;
        }
        public DBContext DBcontext { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost(string username, string password)
        {
            if (DBcontext.Users.Where(propa => propa.UserName == username && propa.Password == password).Any())
            {
                HttpContext.Response.Cookies.Append("username", username);
                HttpContext.Response.Cookies.Append("password", password);

                return RedirectToPage("panel");
            }
            return Page();
        }
    }
}
