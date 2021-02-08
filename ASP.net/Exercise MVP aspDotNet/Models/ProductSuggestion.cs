using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Exercise_MVP_aspDotNet.Models
{
    public class ProductSuggestion
    {
        [Display(Name = "UserName:")]
        [Required(ErrorMessage ="Please enter a username")]
        public string UserName { get; set; }

        [Display(Name = "Description:")]
        [Required(ErrorMessage = "Please enter a Desctiption")]
        public string Description { get; set; }

        [Display(Name = "Product Category:")]
        [Required(ErrorMessage = "Please enter a product category")]
        public string Category { get; set; }

        [Display(Name = "Recommended price:")]
        [Required(ErrorMessage = "Please enter a Price")]
        public string Price { get; set; } 
    }

    internal class ProductSuggestionValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var hr = validationContext.ObjectInstance as ProductSuggestion;

            if (hr == null)
                return new ValidationResult("Cannot validate input");

            return ValidationResult.Success;
        }
    }
}
