using System.ComponentModel.DataAnnotations;

namespace cafefinder.database
{
    public class Place
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        public required string Name { get; set; }
        [Required]
        public string? Neighborhood { get; set; }
        [Required]
        public string City { get; set; } = string.Empty;
        [Required]
        public bool CafeShop { get; set; } = false;
        [Required]
        public bool Restaurant { get; set; } = false;
        [Required]
        public bool FreeSmoke { get; set; } = false;

        public bool FoodAndDrink { get { return (CafeShop && Restaurant); } set { if (value == true) { CafeShop = true; Restaurant = true; } } }
        [Required]
        public bool OpenSpace { get; set; }
        [Required]
        public string? FreeSittingTime { get; set; }
        [Required]
        public bool RoofGarden { get; set; }
        [Required]
        public bool BookCafe { get; set; }
        [Required]
        public bool BirthdayTheme { get; set; }
        [Url]
        public string? Link { get; set; }
        [Url]
        public string? LocationLink { get; set; }
        public List<KeyValuePair<string, float>>? StarRating { get; set; } = new ();
        [Required]
        public required string Address { get; set; }
        public List<KeyValuePair<string, string>>? Photo { get; set; } = new();
    }
    public class User
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        public required string UserName { get; set; }
        [Phone]
        [Required]
        public required string Numberphone { get; set; }
        [Required]
        public required string Password { get; set; }
    }
}
