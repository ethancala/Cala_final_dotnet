namespace Cala_final_dotnet.Models;


public class TemperatureConverterModel
{
    
    /// <summary>
    /// attributes for the tempature
    /// </summary>
    public double? OriginalTemperature { get; set; }
    public string OriginalScale { get; set; } // "Fahrenheit" or "Celsius"
    public string ConvertToScale { get; set; } // "Fahrenheit" or "Celsius"
    public double? ConvertedTemperature { get; set; }
    public string ErrorMessage { get; set; }

    
    //function for convert button
    public void Convert()
    {
        //data validation
        if (OriginalTemperature == null)
        {
            ErrorMessage = "Please enter a valid number.";
            ConvertedTemperature = null;
            return;
        }
        //math to convert, temperature, I used AI

        if (ConvertToScale == "Celsius")
            ConvertedTemperature = Math.Round((OriginalTemperature.Value - 32) * 5 / 9, 3);
        else
            ConvertedTemperature = Math.Round((OriginalTemperature.Value * 9 / 5) + 32, 3);
    }
}
