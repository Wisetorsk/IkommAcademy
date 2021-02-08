using System;
using System.ComponentModel.DataAnnotations;
using System.IO;

namespace HolidayGuru.Models
{
    [HolidayReviewValidation]
    public class HolidayReview
    {
        [Display(Name = "Your name:")]
        [Required(ErrorMessage = "You must give your name")]
        public string Name { get; set; }

        [Display(Name = "Resort:")]
        [Required(ErrorMessage = "Please tell us which resort you're reviewing")]
        public string Resort { get; set; }

        [Display(Name = "Comments:")]
        [Required(ErrorMessage = "Oops! You forgot to add your comments!")]
        public string Comments { get; set; }

        [Display(Name = "Additional info: ")]
        [Required(ErrorMessage = "Pleeeeeeease give me some more information")]
        public string Additional { get; set; }

        // [Required(ErrorMessage = "Oops! You forgot to give us your rating!")]
        [Display(Name = "Rating:")]
        [Required(ErrorMessageResourceType = typeof(MyHelper), ErrorMessageResourceName = nameof(MyHelper.TimestampedError))]
        public int? Rating { get; set; }

        public void Submit()
        {
            using (StreamWriter w = File.CreateText($@"C:\Temp\{Name}.txt"))
            {
                w.WriteLine($"Timestamp: {DateTime.Now}");
                w.WriteLine($"From:      {Name}");
                w.WriteLine($"Resort:    {Resort}");
                w.WriteLine($"Rating:    {Rating}");
                w.WriteLine($"Comments:  {Comments}");
                w.WriteLine($"Additional Information: {Additional}");
            }
        }
    }


    internal class MyHelper
    {
        public static String TimestampedError
        {
            get { return $"Error at {DateTime.Now}"; }
        }
    }


    internal class HolidayReviewValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var hr = validationContext.ObjectInstance as HolidayReview;

            if (hr == null)
                return new ValidationResult("Cannot validate input");

            if (hr.Name == "Erik" && hr.Resort == "Lillehammer")
            {
                return new ValidationResult("Erik, you're not allowed to specify Lillehammer as the resort because you stay there!!!");
            }
            else
            {
                return ValidationResult.Success;
            }
        }
    }
}
