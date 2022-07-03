using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentTask.Models
{
    public class Student
    {
        [Required]
        [RegularExpression(@"^[0-9]{2}-[0-9]{5}-[1-3]{1}$", ErrorMessage = "Id format did not matched")]
        public string Id { get; set; }
        [Required]
        [RegularExpression(@"^[A-Z -. a-z]+$", ErrorMessage = "Name format did not matched")]
        public string Name { get; set; }
        [Required]
        [CustomValidationAge]
        public string Dob { get; set; }
        [Required]
        [MinLength(8)]
        public string Password { get; set; }
        [Required]
        [Compare("Password", ErrorMessage = "Password not matching")]
        public string ConfirmPassword { get; set; }
        [Required]
        [RegularExpression(@"^([a-z0-9\+_\-]+)(\.[a-z0-9\+_\-]+)*@([a-z0-9\-]+\.)+[a-z]{2,6}$", ErrorMessage = "Email format did not matched")]
        public string Email { get; set; }
    }
}