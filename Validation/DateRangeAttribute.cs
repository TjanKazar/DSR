using System;
using System.ComponentModel.DataAnnotations;

public class DateRangeAttribute : ValidationAttribute
{
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
			Console.WriteLine("Nigga : " + value.ToString());

			return false;
        }
    }
}
