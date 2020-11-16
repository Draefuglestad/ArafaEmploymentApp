﻿using ArafaEmploymentApp.CustomValidation;
using System;
using System.ComponentModel.DataAnnotations;

namespace ArafaEmploymentApp.Models
{
    public class EmploymentHistory
    {
        [Display(Name = "Employer Name")]
        public string EmployerName { get; set; }

        [Display(Name = "Employer City")]
        public string EmployerCity { get; set; }

        [Display(Name = "State")]
        public string EmployerState { get; set; }

        [Display(Name = "Zip")]
        public string EmployerZip { get; set; }

        [Display(Name = "Have you previously been fired?")]
        public bool FiredBefore { get; set; }

        [Display(Name = "Days missed in the past month?")]
        public int WorkMissedPastMonth { get; set; }

        [Display(Name = "Days missed in the past six months?")]
        public int WorkMissedPastSixMonths { get; set; }

        [Display(Name = "Days missed in the past year?")]
        public int WorkMissedPastYear { get; set; }

        [Display(Name = "List any additional skills or experience here")]
        public string AdditionalSkills { get; set; }

        [Display(Name = "Contact Employer?")]
        public bool ContactEmployer { get; set; }

        [Display(Name = "Duties Performed, Skills Used, etc")]
        public string Tasks { get; set; }

        // JOE: Not sure where this was supposed to be placed?
        // Does it go in background as in previous salary or current salary? 
        [Display(Name = "What was your salary?")]
        public double PastSalary { get; set; }
    }
}
