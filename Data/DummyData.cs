using System.Collections.Generic;
using System.Linq;
using lab2.Data;
using lab2.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace lab2.Data
{
    public class DummyData
    {

        public static void Initialize(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();
                context.Database.EnsureCreated();
                //context.Database.Migrate();

                // Look for any teams.
                if (context.ProvincesDbset.Any())
                {
                    return;   // DB has already been seeded
                }

                var provinces = DummyData.GetProvinces().ToArray();
                context.ProvincesDbset.AddRange(provinces);
                context.SaveChanges();

                var cities = DummyData.GetCities(context).ToArray();
                context.CitiesDbset.AddRange(cities);
                context.SaveChanges();



            }
        }

        public static List<Province> GetProvinces()
        {
            List<Province> provinces = new List<Province>()
        {
            new Province() {
                ProvinceCode="AB",
                ProvinceName="Alberta",
                //Cities= new List<City>{ context.CitiesDbset.Find(1), context.CitiesDbset.Find(2), context.CitiesDbset.Find(3) }
            },
            new Province() {
                ProvinceCode="BC",
                ProvinceName="British Columbia",
                //Cities= new List<City>{ context.CitiesDbset.Find(4) , context.CitiesDbset.Find(5) , context.CitiesDbset.Find(6) }
            },
            new Province() {
                ProvinceCode="ON",
                ProvinceName="Ontario",
                //Cities= new List<City>{ context.CitiesDbset.Find(7) , context.CitiesDbset.Find(8) , context.CitiesDbset.Find(9) }
            },
        };

            return provinces;
        }

        public static List<City> GetCities(ApplicationDbContext context)
        {
            List<City> cities = new List<City>() {
            new City {
                CityId = 1,
                CityName = "Calgary",
                Population = 1239220,
                ProvinceCode = "AB",
                Province = context.ProvincesDbset.Find("AB")
            },
            new City {
                CityId = 2,
                CityName = "Edmonton",
                Population = 932546,
                ProvinceCode = "AB",
                Province = context.ProvincesDbset.Find("AB")
            },
            new City {
                CityId = 3,
                CityName = "Camrose",
                Population = 18044,
                ProvinceCode = "AB",
                Province = context.ProvincesDbset.Find("AB")
            },
            new City {
                CityId = 4,
                CityName = "Vancouver",
                Population = 603502,
                ProvinceCode = "BC",
                Province = context.ProvincesDbset.Find("BC")
            },
            new City {
                CityId = 5,
                CityName = "Surrey",
                Population = 468251,
                ProvinceCode = "BC",
                Province = context.ProvincesDbset.Find("BC")
            },
            new City {
                CityId = 6,
                CityName = "Burnaby",
                Population = 223218,
                ProvinceCode = "BC",
                Province = context.ProvincesDbset.Find("BC")
            },
            new City {
                CityId = 7,
                CityName = "Toronto",
                Population = 2615060,
                ProvinceCode = "ON",
                Province = context.ProvincesDbset.Find("ON")
            },
            new City {
                CityId = 8,
                CityName = "Ottawa",
                Population = 883391,
                ProvinceCode = "ON",
                Province = context.ProvincesDbset.Find("ON")
            },
            new City {
                CityId = 9,
                CityName = "Mississauga",
                Population = 713443,
                ProvinceCode = "ON",
                Province = context.ProvincesDbset.Find("ON")
            },

        };

            return cities;
        }
    }
}
