using cafefinder.database;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace cafefinder.Pages
{
    public class DashboardModel : PageModel
    {
        private readonly DBContext _context;

        public DashboardModel(DBContext context)
        {
            _context = context;
        }

        public int RestaurantCount { get; set; }
        public int CafeCount { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            info = _context.Places;

            if (!_context.Users.Where(p => p.UserName == HttpContext.Request.Cookies["username"] && p.Password == HttpContext.Request.Cookies["password"]).Any())
            {

                return RedirectToPage("login");
            }


            // دریافت تعداد مردانه ‌ها
            RestaurantCount = _context.Places.Where(p => p.Man).Count();

            // دریافت تعداد زنانه ها
            CafeCount = _context.Places.Where(p => p.Women).Count();

            // سایر مقادیر مشابه را در اینجا اضافه کنید
            return Page();
        }

        public IActionResult OnPostLogout()
        {
            // کدهای مربوط به خروج کاربر، مانند پاک کردن سشن‌ها
            HttpContext.Response.Cookies.Delete("username");
            HttpContext.Response.Cookies.Delete("password");
            // تنظیم پیام موفقیت
            TempData["SuccessMessage"] = "با موفقیت خارج شدید";

            // بازگشت به صفحه‌ی داشبورد یا هر صفحه‌ی دلخواه
            return RedirectToPage("index");
        }


        public IEnumerable<Place?>? info { get; set; }



    }
}
