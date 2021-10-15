using System.Collections.Generic;
using System.Linq;
using Code1stlab.Data;
using Code1stlab.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

public class SampleData
    {
    public static void Initialize(IApplicationBuilder app) {
    using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
    {
      var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();
      context.Database.EnsureCreated();

        // Look for any ailments
        if (context.Cities != null && context.Cities.Any())
          return;   // DB has already been seeded
    
        if (context.Provinces != null && context.Provinces.Any())
          return; 

      var Cities = SampleData.GetCities().ToArray();
      context.Cities.AddRange(Cities);
      context.SaveChanges();

      var Provinces = SampleData.GetProvinces().ToArray();
      context.Provinces.AddRange(Provinces);
      context.SaveChanges();
        }
    }

        public static List<Province> GetProvinces() {
            List<Province> Provinces = new List<Province>() {
                new Province() {
                    ProvinceCode="BC",
                    ProvinceName="British Columbia",
                },
                new Province() {
                    ProvinceCode="AB",
                    ProvinceName="Alberta ",
                },
                new Province() {
                    ProvinceCode="W",
                    ProvinceName="Winnipeg",
                },
            };

            return Provinces;
        }
        public static List<City> GetCities() {
        List<City> Cities = new List<City>() {
            new City() {
                CityId = 1,
                CityName = "vancouver",
                Population = 10258,
                ProvinceCode = "BC"

            },
            new City() {
                CityId = 2,
                CityName = "calgary",
                Population = 125234,
                ProvinceCode = "AB"

            },
            new City() {
                CityId = 3,
                CityName = "Sask",
                Population = 340,
                ProvinceCode = "W"

            },
        };

        return Cities;
    }


    }
