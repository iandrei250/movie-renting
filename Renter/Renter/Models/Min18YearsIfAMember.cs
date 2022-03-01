﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Renter.Models
{
    public class Min18YearsIfAMember:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;

            if(customer.MembershipTypeId == MembershipType.Unknown || customer.MembershipTypeId == MembershipType.PayAsYouGo)
            {
                return ValidationResult.Success;
            }
            if(customer.Birthday == null)
            {
                return new ValidationResult("Birthdate is required");
            }

            var customerDate = Convert.ToDateTime(customer.Birthday);
            var age = DateTime.Today.Year - customerDate.Year;

            return (age >= 18) ? ValidationResult.Success : new ValidationResult("Customer should be at least 18 years old to go on a membership");
        }
    }
}
