using System;
using System.ComponentModel.DataAnnotations;

public class DateRangeAttribute : ValidationAttribute
{
    public string FormatErrorMessage { get; set; } = "Datum mora biti v pravilnem formatu (dd.mm.llll).";
    public string RangeErrorMessage { get; set; } = "Datum mora biti večji od leta 1900 in manjši od današnjega dne.";

    public override bool IsValid(object value)
    {
        if (value is DateTime date)
        {
            if (date > new DateTime(1900, 1, 1) && date < DateTime.Today)
            {
                return true;
            }
            else
            {
                ErrorMessage = "Datum mora biti večji od leta 1900 in manjši od današnjega dne.";
                return false;
            }
        }
        else
        {
            ErrorMessage = "Datum mora biti v pravilnem formatu (dd.mm.llll).";
            return false;
        }
    }
}
