using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Form.Models
{
    public class AgeValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is DateTime dob) 
            {
                var age = DateTime.Today.Year -dob.Year;

                if(age < 18)
                {
                    return new ValidationResult("You must be 18 years old");
                }
            }
            //return base.IsValid(value, validationContext);
            return ValidationResult.Success;
        }
    }
}