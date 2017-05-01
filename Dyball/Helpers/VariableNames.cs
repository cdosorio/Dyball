using Humanizer;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace Dyball.Helpers
{
    public static class VariableNames
    {
        public static string CamelizedName(this ModelExpression modelExpression)
        {
            var className = modelExpression.Metadata.ContainerType.Name;
            var propertyName = modelExpression.Name;

            return className.Camelize() + "." + propertyName.Camelize();
        }
    }
}
