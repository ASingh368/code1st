using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Code1stlab.Models
{
    public class Province
    {
        [Key]
        public string ProvinceCode { get;set; }
        [Display(Name="Province")]
        public string ProvinceName { get;set; }

        public List<City> Cities { get;set; }
    }
}