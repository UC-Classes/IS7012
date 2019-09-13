using System;
using System.ComponentModel.DataAnnotations;

namespace CoreCrud.Models
{
    public class Destination
    {
        public int ID { get; set; }
        public string TripName { get; set; }
        [DataType(DataType.Date)]
        public DateTime LeaveDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public string NationalParks { get; set; }
        public string DiveSites { get; set; }
        public decimal Budget { get; set; }
        public int LocationID { get; set; }
        public Country Location { get; set; }
    }
}