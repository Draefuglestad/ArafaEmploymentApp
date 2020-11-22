using ArafaEmploymentApp.CustomValidation;
using System;
using System.ComponentModel.DataAnnotations;


namespace ArafaEmploymentApp.Models
{
    public class References
    {
        [Display(Name = "Reference email")]
        //[Required(ErrorMessage = "Must enter a reference email")]
        public string ReferenceEmail { get; set; }

        [Display(Name = "Reference full name")]
        //[Required(ErrorMessage = "Must enter a reference name")]
        public string ReferenceFullName { get; set; }

        [Display(Name = "Phone")]
        [Phone]
        [StringLength(10, ErrorMessage = "Incorrect length")]
        //[Required(ErrorMessage = "Must enter a reference number")]
        public string ReferencePhoneNumber { get; set; }



    }
}
