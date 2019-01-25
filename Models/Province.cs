using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace lab2.Models
{
    public class Province
    {
        [Key]
        public string ProvinceCode { set; get; }
        public string ProvinceName { set; get; }
        public List<City> Cities { get; set; }
    }
}
