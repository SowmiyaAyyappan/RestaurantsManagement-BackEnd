namespace RestaurantsManagement.Models
{
    public class Restaurant
    {
        public int Id { get; set; }

        public string? RestaurantName { get; set; }

        public string? RestaurantLocation { get; set; }

        public float StarRating { get; set; }

        public string? Cuisine { get; set; }

        public string? Category { get; set; }

        public int ContactNumber { get; set; }

        public string? Image { get; set; }

        public string? Address { get; set; }

        public string? SignatureDish { get; set; }
    }
}
