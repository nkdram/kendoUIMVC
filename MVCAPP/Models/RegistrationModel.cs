using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVCAPP.Models
{
    public class RegistrationModel
    {

        [Required(ErrorMessage = "Please enter an Email")]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your name")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Contact No")]
        public string ContactNo { get; set; }



        [Required]
        [Display(Name = "Blood Group")]
        public string BloodGroup { get; set; }

        [Required]
        [Display(Name = "Address")]
        public string Address { get; set; }


        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public System.DateTime DOB { get; set; }
    }
}