using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArafaEmploymentApp.CustomValidation;
using System.ComponentModel.DataAnnotations;

namespace ArafaEmploymentApp.Models
{
    public class Education
    {
        [Display(Name = "Additional Diplomas, Degrees, etc.")]
        public string AdditionalEducation { get; set;}

        [Display(Name = "Highest Education Earned?")]
        [Required(ErrorMessage = "Highest Education Required")]
        public string HighestEducationEarned { get; set;}

        [Display(Name = "School Name")]
        public string SchoolName { get; set; }

        [Display(Name = "Graduation Date")]
        [DataType(DataType.Date)]
        public DateTime? GraduationDate { get; set; }

        [Display(Name = "School State")]
        public string SchoolState { get; set;}
    }
}
