namespace CarShop.Models
{
    public static class DbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetRequiredService<CarShopDbContext>();

                // Ensure the database is created
                context.Database.EnsureCreated();

                // Check if there are already companies in the database
                if (!context.Companies.Any())
                {
                    var companies = new List<Company>
                    {
                        new Company
                        {
                            Name = "Tesla",
                            Cars = new List<Car>
                            {
                                new Car
                                {
                                    Name = "Model S",
                                    Price = 79999,
                                    CreationYear = 2021,
                                    ImageURL = "Model S.jpg",
                                    Properties = "Electric, 396 mi range, 0-60 mph in 1.99s",
                                },
                                new Car
                                {
                                    Name = "Model 3",
                                    Price = 39999,
                                    CreationYear = 2022,
                                    ImageURL = "Model 3.jpg",
                                    Properties = "Electric, 272 mi range, 0-60 mph in 3.1s",
                                }
                            }
                        },
                        new Company
                        {
                            Name = "Toyota",
                            Cars = new List<Car>
                            {
                                new Car
                                {
                                    Name = "Corolla",
                                    Price = 20000,
                                    CreationYear = 2020,
                                    ImageURL = "Corolla.jpg", // Update this with a real URL
                                    Properties = "Hybrid, 52 mpg city/highway",
                                },
                                new Car
                                {
                                    Name = "Camry",
                                    Price = 25000,
                                    CreationYear = 2021,
                                    ImageURL = "Camry.jpg", // Update this with a real URL
                                    Properties = "Gas, 28 mpg city / 39 mpg highway",
                                },
                                new Car
                                {
                                    Name = "RAV4",
                                    Price = 27000,
                                    CreationYear = 2021,
                                    ImageURL = "RAV4.jpg", // Update this with a real URL
                                    Properties = "SUV, 203 hp, 8-speed automatic",
                                }
                            }
                        },
                        new Company
                        {
                            Name = "BMW",
                            Cars = new List<Car>
                            {
                                new Car
                                {
                                    Name = "X5",
                                    Price = 60000,
                                    CreationYear = 2022,
                                    ImageURL = "X5.jpg",
                                    Properties = "SUV, 335 hp, all-wheel drive",
                                },
                                new Car
                                {
                                    Name = "3 Series",
                                    Price = 45000,
                                    CreationYear = 2021,
                                    ImageURL = "3 Series.jpg",
                                    Properties = "Sedan, 255 hp, 0-60 mph in 5.6s",
                                }
                            }
                        }
                    };

                    context.Companies.AddRange(companies);
                    context.SaveChanges();
                }
            }
        }
    }
}
