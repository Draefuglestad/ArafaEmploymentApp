﻿using ArafaEmploymentApp.CustomValidation;
using System;
using System.ComponentModel.DataAnnotations;

namespace ArafaEmploymentApp.Models
{
    public class Availability
    {
        [Display(Name = "Days available to work")]
        public string DaysAvailable { get; set; }

        [Display(Name = "Employment Desired (Full-time, Part-time)")]
        public string DesiredEmployment { get; set; }

        [Display(Name = "Hours weekly able to work")]
        public int HoursAvailable { get; set; }

        [Display(Name = "Work Nights?")]
        public bool WorkNights { get; set; }

        [Required(ErrorMessage = "Please choose date.")]
        [Display(Name = "Date Available to Work")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
    }
}
