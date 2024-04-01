using DSR_KAZAR_N1.Models;
using System.ComponentModel.DataAnnotations;

public class EmsoValidationAttribute : ValidationAttribute
{
    public override bool IsValid(object value)
    {
        if (value == null || !(value is string emso))
        {
            return false;
        }

        return emso.Length == 13 && IsNumeric(emso);
    }

    private bool IsNumeric(string value)
    {
        foreach (char c in value)
        {
            if (!char.IsDigit(c))
            {
                return false;
            }
        }
        return true;
    }

    public override string FormatErrorMessage(string name)
    {
        return $"Polje EMŠO mora vsebovati natanko 13 številk.";
    }
}
