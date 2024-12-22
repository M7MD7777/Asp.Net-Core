namespace CarShop.Models
{
    public class Company
    {
        public int CompanyId { get; set; }

        public string Name { get; set; }=string.Empty;

        public List<Car>? Cars { get; set; }

    }
}
