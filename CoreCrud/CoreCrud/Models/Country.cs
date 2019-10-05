using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoreCrud.Models
{
    public class Country
    {
        public ICollection<Destination> Destinations { get; set; }
        public int ID { get; set; }
        [Display(Name = "Country Name")]
        [StringLength(200, MinimumLength = 2)]
        public string CountryName { get; set; }
        
    }
}
