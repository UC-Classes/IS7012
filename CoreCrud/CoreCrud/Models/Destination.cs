using System;
using System.ComponentModel.DataAnnotations;

namespace CoreCrud.Models
{
    public class Destination
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Please provide a name")]
        [StringLength(100, MinimumLength = 2)]
        [Display(Name = "Trip Name")]
        public string TripName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [CustomValidation(typeof(Destination), "LeaveDateValidation")]
        [Display(Name = "Leave Date")]
        public DateTime LeaveDate { get; set; }
        
        public static ValidationResult LeaveDateValidation(DateTime? LeaveDate, ValidationContext context)
        {
            if (LeaveDate == null)
            {
                return ValidationResult.Success;
            }
            if (LeaveDate.Value.Date <= DateTime.Today)
            {
                return ValidationResult.Success;
            }
            string errorMessage = $"Leave date must be a date on or before { DateTime.Today.ToShortDateString() }";
            return new ValidationResult(errorMessage);
        }

        [Required]
        [CustomValidation(typeof(Destination), "ReturnDateValidation")]
        [DataType(DataType.Date)]
        [Display(Name = "Return Date")]
        public DateTime ReturnDate { get; set; }


        public static ValidationResult ReturnDateValidation(DateTime? ReturnDate, ValidationContext context)
        {
            if (ReturnDate == null)
            {
                return ValidationResult.Success;
            }
            var instance = context.ObjectInstance as Destination;
            if (instance == null)
            {
                return ValidationResult.Success;
            }
            if (ReturnDate > instance.LeaveDate)
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("Date Return must be after date Leave");
        }
        
        [Url(ErrorMessage = "Please provide a valid linkedin url")]
        [StringLength(500, MinimumLength = 2)]
        [Display(Name = "National Parks")]
        public string NationalParks { get; set; }

        [StringLength(100, MinimumLength = 2)]
        [Display(Name = "Dive Sites")]
        public string DiveSites { get; set; }

        [Required]
        [Range(1, 1000000000, ErrorMessage = "Budget must be less than $1 Billion USD")]
        public decimal Budget { get; set; }

        [Display(Name = "Location")]
        public int LocationID { get; set; }
        public Country Location { get; set; }

    }
}