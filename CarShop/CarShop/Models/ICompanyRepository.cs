namespace CarShop.Models
{
    public interface ICompanyRepository
    {
        IEnumerable<Company> GetAllCompanies { get; }

    }
}
