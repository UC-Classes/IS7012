using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoreCrud.Models
{
    public class Country
    {
        public ICollection<Destination> Destinations { get; set; }
        public int ID { get; set; }
        public string CountryName { get; set; }
        
    }
}
