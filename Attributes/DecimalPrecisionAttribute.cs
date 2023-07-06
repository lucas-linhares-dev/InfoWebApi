using System.ComponentModel.DataAnnotations;

namespace InfoWeb.Attributes;

public class DecimalPrecisionAttribute : RegularExpressionAttribute
{
    public DecimalPrecisionAttribute() : base(@"^\d{1,12}(\.\d{1,2})?$")
    {
        ErrorMessage = "O campo {0} deve ter até 12 dígitos inteiros e até 2 casas decimais.";
    }
}
