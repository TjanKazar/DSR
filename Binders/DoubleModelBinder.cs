using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using System.Web.Mvc;

public class DoubleModelBinder : DefaultModelBinder
{
    public override object BindModel(System.Web.Mvc.ControllerContext controllerContext, System.Web.Mvc.ModelBindingContext bindingContext)
    {
        var result = bindingContext.ValueProvider.GetValue(bindingContext.ModelName);
        if (result != null && !string.IsNullOrEmpty(result.AttemptedValue))
        {
            if (bindingContext.ModelType == typeof(double))
            {
                double temp;
                var attempted = result.AttemptedValue.Replace(",", ".");
                if (double.TryParse(
                    attempted,
                    NumberStyles.Number,
                    CultureInfo.InvariantCulture,
                    out temp)
                )
                {
                    return temp;
                }
            }
        }
        return base.BindModel(controllerContext, bindingContext);
    }
}