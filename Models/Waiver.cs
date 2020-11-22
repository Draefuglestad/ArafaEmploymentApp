using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

using ArafaEmploymentApp.CustomValidation;
namespace ArafaEmploymentApp.Models
{
    public class Waiver
    {
        [Display(Name = "Please provide signature")]
        [Required(ErrorMessage ="Must provide signature")]
        public string Signature { get; set; }

        [Required(ErrorMessage = "Please choose date.")]
        [Display(Name = "Today's Date")]
        [DataType(DataType.Date)]
        [CustomAdmissionDate(ErrorMessage = "Date must be less than or equal to Today's Date.")]
        public DateTime AdmissionDate { get; set; }
    }
}
