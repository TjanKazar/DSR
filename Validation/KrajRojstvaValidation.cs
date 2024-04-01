using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class KrajRojstvaValidation : ValidationAttribute
{
    private readonly List<string> _validPlaces;

    public KrajRojstvaValidation()
    {
        _validPlaces = new List<string> { "Ljubljana", "Marbor", "Murska Sobota", "Celje", "Portorož" };
    }

    public override bool IsValid(object value)
    {
        if (value == null || !(value is string place))
        {
            return false;
        }
        return _validPlaces.Contains(place);
    }

    public override string FormatErrorMessage(string name)
    {
        return $"The {name} field must be one of the valid options.";
    }
}
