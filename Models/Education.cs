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
    }
}
