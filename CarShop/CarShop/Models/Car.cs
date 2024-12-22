namespace CarShop.Models
{
    public class Car
    {
        public int CarId { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }

        public int CreationYear { get; set; }

        public string ImageURL { get; set; }

        public string Properties { get; set; }

        public int CompanyId { get; set; }

        public Company Company { get; set; } = default!;
    }
}
