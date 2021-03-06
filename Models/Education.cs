﻿using System;
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
        [Required(ErrorMessage = "Must provide an answer, if none type 'none' ")]
        public string AdditionalEducation { get; set;}

        [Display(Name = "Highest Education Earned?")]
        [Required(ErrorMessage = "Must provide an answer, if none type 'none' ")]
        public string HighestEducationEarned { get; set;}

        [Display(Name = "Current School Name")]
        [Required(ErrorMessage = "Must provide an answer, if none type 'none' ")]
        public string SchoolName { get; set; }

        [Display(Name = "High School Graduation Date (if applicable)")]
        [DataType(DataType.Date)]
        public DateTime? GraduationDate { get; set; }

        [Display(Name = "School State")]
        [Required(ErrorMessage = "Must provide an answer, if none select 'none' ")]
        public string SchoolState { get; set;}
    }
}
