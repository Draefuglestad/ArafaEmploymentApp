using ArafaEmploymentApp.CustomValidation;
using System;
using System.ComponentModel.DataAnnotations;

namespace ArafaEmploymentApp.Models
{
    public class Applicant
    {
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Please enter first name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Please enter last name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please choose date.")]
        [Display(Name = "Today's Date")]
        [DataType(DataType.Date)]
        [CustomAdmissionDate(ErrorMessage = "Date must be less than or equal to Today's Date.")]
        public DateTime AdmissionDate { get; set; }

        [Required(ErrorMessage = "Please choose date.")]
        [Display(Name = "Date Available to Work")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Display(Name = "Address")]
        [Required(ErrorMessage = "Please enter street address")]
        public string AddressStreet { get; set; }//changed address types to multiple fields

        [Display(Name = "City")]
        [Required(ErrorMessage = "Please enter address city")]
        public string AddressCity { get; set; }

        [Display(Name = "State")]
        [Required(ErrorMessage = "Please enter address state")]
        public string AddressState { get; set; }

        [Display(Name = "Zip")]
        [Required(ErrorMessage = "Please enter address zip code")]
        public string AddressZip { get; set; }

        [Display(Name = "Years lived at address")]
        [Required(ErrorMessage = "Please enter years lived at address")]
        public int AddressYears { get; set; }

        [Display(Name = "Social Security")]
        [Required(ErrorMessage = "Please enter social security number")]
        public string SSN { get; set; }

        [Display(Name = "Phone")]
        [Phone]
        [Required(ErrorMessage = "Please enter a phone number")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        [LegalAge]
        [Required(ErrorMessage = "Must enter age")]
        public DateTime DateofBirth { get; set; }//changed legal age from boolean to date type with age validation

        [Display(Name = "Position applying for")]
        [Required(ErrorMessage = "Please enter position applied for")]
        public string PositionApplied { get; set; }

        [Display(Name = "Email address")]
        [Required(ErrorMessage = "Please enter email address")]
        //[EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Display(Name = "Desired Salary")]
        public decimal DesiredSalary { get; set; } //Changed from Double to Decimal

        [Display(Name = "Emergency Contact First Name")]
        public string EmergencyFirstName { get; set; }

        [Display(Name = "Emergency Contact Middle Name")]
        public string EmergencyMiddleName { get; set; }

        [Display(Name = "Emergency Contact Last Name")]
        public string EmergencyLastName { get; set; }

        [Display(Name = "Emergency Address")]
        public string EmergencyAddressStreet { get; set; }

        [Display(Name = "Emergency City")]
        public string EmergencyAddressCity { get; set; }

        [Display(Name = "Emergency State")]
        public string EmergencyAddressState { get; set; }

        [Display(Name = "Emergency Zip")]
        public string EmergencyAddressZip { get; set; }

        [Display(Name = "Emergency Phone")]
        [Phone]
        public string EmergencyPhoneNumber { get; set; }

        [Display(Name = "Emergency Email address")]
        [EmailAddress]
        public string EmergencyEmail { get; set; }

        [Display(Name = "Emergency Relationship")]
        public string EmergencyRelationship { get; set; }

        //[Display(Name = "Medical History")]
        //public string[] MedicalHistory { get; set; }

        //[Display(Name = "Race")]
        //[Required(ErrorMessage = "Please enter your race")]
        //public string[] Race { get; set; }

        //[Display(Name = "Gender")]
        //[Required(ErrorMessage = "Please enter your gender")]
        //public string[] Gender { get; set; }

        [Display(Name = "Days available to work")]
        public string DaysAvailable { get; set; }

        [Display(Name = "Employment Desired (Full-time, Part-time)")]
        public string DesiredEmployment { get; set; }

        [Display(Name = "Hours weekly able to work")]
        public int HoursAvailable { get; set; }

        [Display(Name = "Work Nights?")]
        public bool WorkNights { get; set; }

        [Display(Name = "Have you previously been fired?")]
        public bool FiredBefore { get; set; }



        [Display(Name = "Do you have a driver's license?")]
        public bool DriversLicense { get; set; }

        [Display(Name = "Driver's license #")]
        public string DLNum { get; set; }

        [Display(Name = "Driver's license Issue Date")]
        public string DLIssueState { get; set; }

        [Required(ErrorMessage = "Please choose date.")]
        [Display(Name = "Driver's license expires:")]
        [DataType(DataType.Date)]
        public DateTime DLExpireDate { get; set; }

   

        [Display(Name = "Have any children?")]
        public bool HasChildren { get; set; }

        [Display(Name = "How many children?")]
        public int NumOfChildren { get; set; }


        // Do you currently have health insurance?
        // Changed from string to seperate boolean fields for yourself/spouse/children.

        [Display(Name = "Yourself")]
        public bool HaveHealthInsuranceYourself { get; set; }

        [Display(Name = "Spouse")]
        public bool HaveHealthInsuranceSpouse { get; set; }

        [Display(Name = "Children")]
        public bool HaveHealthInsuranceChildren { get; set; }
    }
}