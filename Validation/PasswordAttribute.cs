using System.ComponentModel.DataAnnotations;

public class PasswordAttribute : ValidationAttribute
{
    public override bool IsValid(object value)
    {
        if (value == null || !(value is string password))
        {
            return false;
        }
        return System.Text.RegularExpressions.Regex.IsMatch(password, @"^(?=.*[0-9])(?=.*[^a-zA-Z0-9\s]).{6,}$");
    }

    public override string FormatErrorMessage(string name)
    {
        return $"Polje Geslo mora biti vsaj 6 znakov dolgo. Od teh znakov mora vsebovati vsaj Eno Številko (0-9) in en posebni znak (!, @, $, &, itd.).";
    }
}