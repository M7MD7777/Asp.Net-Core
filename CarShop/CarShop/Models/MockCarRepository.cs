namespace CarShop.Models
{
    public class MockCarRepository : ICarRepository
    {
        private readonly ICompanyRepository _companyRepository=new MockCompanyRepository();
        public IEnumerable<Car> GetAllCars =>
            new List<Car>
            {
                new Car{CarId=1,Name="X7",Price=7000,CreationYear=2018,ImageURL="BMWX7.jpg",Properties="Vey Strong",CompanyId=1,Company=_companyRepository.GetAllCompanies.ToList()[0]},
                new Car{CarId=1,Name="3 Series",Price=5500,CreationYear=2020,ImageURL="3Series.jpg",Properties="Vey Class",CompanyId=1,Company=_companyRepository.GetAllCompanies.ToList()[0]},
                new Car{CarId=1,Name="XC60",Price=8000,CreationYear=2025,ImageURL="XC60.jpg",Properties="Vey Fast",CompanyId=2,Company=_companyRepository.GetAllCompanies.ToList()[2]},
                new Car{CarId=1,Name="Model Y",Price=10000,CreationYear=2019,ImageURL="TeslaY.jpg",Properties="Vey Economic",CompanyId=3,Company=_companyRepository.GetAllCompanies.ToList()[2]},
            };

        public IEnumerable<Car> GetCheapCars => throw new NotImplementedException();

        public Car? GetCarById(int id) => GetAllCars.FirstOrDefault(p => p.CarId == id);

        public IEnumerable<Car> SearchCars(string query)
        {
            throw new NotImplementedException();
        }
    }
}
