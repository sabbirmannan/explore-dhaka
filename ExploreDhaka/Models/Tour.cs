using System.ComponentModel.DataAnnotations;

namespace ExploreDhaka.Models
{
    public class Tour
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Display(Name = "Lenth in Days")]
        [Range(1, 99)]
        public int Length { get; set; }

        public decimal Price { get; set; }

        public string Rating { get; set; }

        [Display(Name = "Includes Meals")]
        public bool IncludesMeals { get; set; }

        public bool DiscountEligible { get; set; }

    }
}
