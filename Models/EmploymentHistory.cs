using ArafaEmploymentApp.CustomValidation;
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
        [Display(Name = "Past month?")]
        public int WorkMissedPastMonth { get; set; }


        [Display(Name = "Have you previously been fired?")]
        public bool FiredBefore { get; set; }

        [Display(Name = "Past six months?")]
        public int WorkMissedPastSixMonths { get; set; }

        [Display(Name = "Past year?")]
        public int WorkMissedPastYear { get; set; }
    }
}
