using System.Collections.Generic;
using Code1stlab.Models;


    public class SampleData
    {
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
