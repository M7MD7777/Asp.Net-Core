using CarShop.Models;

namespace CarShop.Models
{
    public class MockCompanyRepository:ICompanyRepository
    {
        public IEnumerable<Company> GetAllCompanies =>
                        new List<Company>{
            new Company{CompanyId=1,Name="BMW"},
            new Company{CompanyId=2,Name="VOLVO"},
            new Company{ CompanyId = 3, Name = "Tesla" },

                         };

    }
}
    
