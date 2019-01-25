using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace lab2.Models
{
    public class City
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CityId { set; get; }
        public string CityName { set; get; }
        public int Population { set; get; }
        public string ProvinceCode { set; get; }
        public Province Province { set; get; }
    }
}
