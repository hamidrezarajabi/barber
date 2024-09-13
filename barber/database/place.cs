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
        public bool DamadArosGrim { get; set; } = false;
        [Required]
        public bool PaksaziSorat { get; set; } = false;
        [Required]
        public bool Man { get; set; } = false;
        [Required]
        public bool Women { get; set; } = false;
        [Required]
        public bool keratin { get; set; } = false;
        [Required]
        public bool feshial { get; set; } = false;
        [Required]
        public bool kashtnakhon { get; set; } = false;
        [Required]
        public bool Childeren { get; set; } = false;

        [Required]
        public string? WorkTime { get; set; }
        [Url]
        public string? LocationLink { get; set; }
        public List<KeyValuePair<string, float>>? StarRating { get; set; } = new ();
        [Required]
        public required string Address { get; set; }
        public List<KeyValuePair<string, string>>? Photo { get; set; } = new();

        [Required]
        public required string UserName { get; set; }
        [Required]
        public required string Password { get; set; }

        public List<string>? rezerv { get; set; } = new();
        public Dictionary<string , string>? selectrezerv { get; set; } = new();


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
