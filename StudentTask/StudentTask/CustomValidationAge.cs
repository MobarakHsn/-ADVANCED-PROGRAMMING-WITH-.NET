using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentTask
{
    public class CustomValidationAge : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if(value!=null)
            {
                string date = value.ToString();
                var prevdate = DateTime.Parse(date);
                var curdate = DateTime.Today;

                var diff = curdate - prevdate;
                int days = (int)diff.TotalDays;
                int year = days / 365;
                if(year<18)
                    return new ValidationResult("Age must be >=18");
            }
            return ValidationResult.Success;
        }
    }
}