using ArafaEmploymentApp.CustomValidation;
using System;
using System.ComponentModel.DataAnnotations;


namespace ArafaEmploymentApp.Models
{
    public class References
    {
        [Display(Name = "Reference email")]
        public string ReferenceEmail { get; set; }

        [Display(Name = "Reference full name")]
        public string ReferenceFullName { get; set; }

        [Display(Name = "Phone")]
        [Phone]
        [Required(ErrorMessage = "Please enter a phone number")]
        public string ReferencePhoneNumber { get; set; }



        [Display(Name = "Please provide signature")]
        [Required]
        public string Signature { get; set; }

        [Required(ErrorMessage = "Please choose date.")]
        [Display(Name = "Today's Date")]
        [DataType(DataType.Date)]
        [CustomAdmissionDate(ErrorMessage = "Date must be less than or equal to Today's Date.")]
        public DateTime AdmissionDate { get; set; }


    }
}
