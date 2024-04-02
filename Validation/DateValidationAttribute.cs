using System;
using System.ComponentModel.DataAnnotations;

public class DateFormatValidationAttribute : ValidationAttribute
{
    private readonly string _expectedFormat;

    public DateFormatValidationAttribute(string expectedFormat)
    {
        _expectedFormat = expectedFormat;
    }

    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (value == null || !(value is DateTime))
        {
            return new ValidationResult(ErrorMessage);
        }

        DateTime dateValue = (DateTime)value;
        string formattedDate = dateValue.ToString(_expectedFormat);

        if (!DateTime.TryParseExact(formattedDate, _expectedFormat, null, System.Globalization.DateTimeStyles.None, out _))
        {
            return new ValidationResult(ErrorMessage);
        }

        return ValidationResult.Success;
    }
}
