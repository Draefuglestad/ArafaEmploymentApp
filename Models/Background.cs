using ArafaEmploymentApp.CustomValidation;
using System;
using System.ComponentModel.DataAnnotations;


namespace ArafaEmploymentApp.Models
{
    public class Background
    {
        [Display(Name = "Did you serve in the military?")]
        public bool MilitaryService { get; set; }

        [Display(Name = "Where you honorably discharged?")]
        public bool MilitaryDischarge { get; set; }

        [Display(Name = "Years Served")]
        public int YearServed { get; set; }


        [Display(Name = "Convicted of a crime?")]
        public bool CrimeBefore { get; set; }

        [Display(Name = "If so, what?")]
        public string CrimeType { get; set; }

        [Display(Name = "Military Branch (Army, Marines, Navy, Air Force, Coast Guard)")]
        public string MilitaryBranch { get; set; }

        [Display(Name = "Traffic Accidents in the past 3 years?")]
        public int TrafficAccident { get; set; }

        [Display(Name = "Traffic Violations in the past 3 years?")]
        public int TrafficViolation { get; set; }

        [Display(Name = "Were you stopped for suspicion of drinking and driving?")]
        public bool DrinkAndDrive { get; set; }

        [Display(Name = "Were you stopped for suspicion of distracted driving?")]
        public bool DistractedDrive { get; set; }
    }
}
