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
            modelBuilder.Entity<Place>().Property(p => p.rezerv).HasConversion(p => Newtonsoft.Json.JsonConvert.SerializeObject(p), p => Newtonsoft.Json.JsonConvert.DeserializeObject<List<string>>(p));
            modelBuilder.Entity<Place>().Property(p => p.selectrezerv).HasConversion(p => Newtonsoft.Json.JsonConvert.SerializeObject(p), p => Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, string>>(p));

            modelBuilder.Entity<Place>().HasData(new Place()
            {
                Name = "سالن زیبایی آنارام",
                Neighborhood = "سجاد",
                Address = "بلوار سجاد ، گلریز 1",
                DamadArosGrim = true,
                feshial = true,
                kashtnakhon = true,
                keratin = true,
                PaksaziSorat = true,
                WorkTime = "ساعت 10 الی 22",
                Man = false,
                Women = true,
                Childeren=false,
                LocationLink = "https://www.mrk.co.ir",
                City = "mashhad",
                UserName = "anaram",
                Password = "Password",
            }
           , new Place()
           {
               Name = "آرایشگاه مردانه کامران",
               Neighborhood = "ملک آباد",
               Address = "بلوار سجاد ، بزرگمهر جنوبی 3",
               DamadArosGrim = true,
               feshial = false,
               kashtnakhon = false,
               keratin = true,
               PaksaziSorat = true,
               Childeren = true,
               WorkTime = "ساعت 8 الی 20",
               Man = true,
               Women = false,
               LocationLink = "https://www.mrk.co.ir",
               City = "mashhad",
               UserName = "kamran-sajad",
               Password = "Password",
           },
           new Place()
           {
               Name = "سالن زیبایی ماه مریم",
               Neighborhood = "حامد شمالی",
               Address = "بلوار سجاد ، حامد شمالی 5 ",
               DamadArosGrim = false,
               feshial = true,
               kashtnakhon = false,
               keratin = true,
               PaksaziSorat = true,
               Childeren = true,
               WorkTime = "ساعت 8 الی 23",
               Man = false,
               Women = true,
               LocationLink = "https://www.mrk.co.ir",
               City = "mashhad",
               UserName = "maryam-moon",
               Password = "Password",
           });

            modelBuilder.Entity<User>().HasData(new User()
            {
                UserName = "admin",
                Password = "cafe1403admin*",
                Numberphone = "09334101438"
            });
        }
        public DbSet<Place> Places { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
