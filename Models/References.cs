﻿using ArafaEmploymentApp.CustomValidation;
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



    }
}