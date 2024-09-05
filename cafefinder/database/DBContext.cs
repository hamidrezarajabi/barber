using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using Microsoft.VisualBasic;
using System.Net;

namespace cafefinder.database
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Place>().Property(p => p.StarRating).HasConversion(p => Newtonsoft.Json.JsonConvert.SerializeObject(p), p => Newtonsoft.Json.JsonConvert.DeserializeObject<List<KeyValuePair<string, float>>>(p));
            modelBuilder.Entity<Place>().Property(p => p.Photo).HasConversion(p => Newtonsoft.Json.JsonConvert.SerializeObject(p), p => Newtonsoft.Json.JsonConvert.DeserializeObject<List<KeyValuePair<string, string>>>(p));

            modelBuilder.Entity<Place>().HasData(new Place()
            {
                Name = "ماه من",
                Neighborhood = "سجاد",
                CafeShop = true,
                Restaurant = false,
                FreeSmoke = true,
                FoodAndDrink = false,
                OpenSpace = true,
                RoofGarden = true,
                FreeSittingTime = "45 min",
                BirthdayTheme = false,
                BookCafe = true,
                Address = "بلوار سجاد، پاساژ لاله ، انتهای پاساژ طبقه اول",
                Link = "www.mrk.co.ir",
                LocationLink = "www.mrk.co.ir",
                City = "mashhad",
            }
           , new Place()
           {
               Name = "خانه اکنون",
               Neighborhood = "سجاد",
               FreeSmoke = true,
               FoodAndDrink = true,
               OpenSpace = true,
               RoofGarden = false,
               FreeSittingTime = "free time",
               BirthdayTheme = false,
               BookCafe = true,
               Address = "بلوار سجاد ،چهارراه گلریز ، گلریز4،یاس3",
               Link = "www.miranagency.ir",
               LocationLink = "www.miranagency.ir",
               City = "mashhad",
           },
           new Place()
           {
               Name = " لیالی لبنان",
               Neighborhood = "وکیل آباد",
               CafeShop = false,
               Restaurant = true,
               FreeSmoke = false,
               OpenSpace = true,
               RoofGarden = false,
               FreeSittingTime = "free time",
               BirthdayTheme = false,
               BookCafe =false,
               Address = "وکیل آباد 13",
               Link = "www.miranagency.ir",
               LocationLink = "www.miranagency.ir",
               City = "mashhad",
           });


        }
        public DbSet<Place> Places { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
