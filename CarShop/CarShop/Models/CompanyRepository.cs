
namespace CarShop.Models
{
    public class CompanyRepository : ICompanyRepository
    {

        private readonly CarShopDbContext _context;

        public CompanyRepository(CarShopDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Company> GetAllCompanies => _context.Companies.OrderBy(c=>c.Name);
    }
}
