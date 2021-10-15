using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Code1stlab.Models
{
    public class City
    {
        
        public int CityId { get;set; }

        [Display(Name="City")]
        public string CityName { get;set; }

        public int Population { get;set; }

        public string ProvinceCode {get;set; }

        [ForeignKey("ProvinceCode")]
        public  Province Province {get;set;}



    }
}