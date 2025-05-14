namespace Cala_final_dotnet.Models;


public class TemperatureConverterModel
{
    
    public double? OriginalTemperature { get; set; }
    public string OriginalScale { get; set; } // "Fahrenheit" or "Celsius"
    public string ConvertToScale { get; set; } // "Fahrenheit" or "Celsius"
    public double? ConvertedTemperature { get; set; }
    public string ErrorMessage { get; set; }

    public void Convert()
    {
        if (OriginalTemperature == null)
        {
            ErrorMessage = "Please enter a valid number.";
            ConvertedTemperature = null;
            return;
        }

        if (ConvertToScale == "Celsius")
            ConvertedTemperature = Math.Round((OriginalTemperature.Value - 32) * 5 / 9, 3);
        else
            ConvertedTemperature = Math.Round((OriginalTemperature.Value * 9 / 5) + 32, 3);
    }
}
