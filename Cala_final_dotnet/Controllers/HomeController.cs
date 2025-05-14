using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Cala_final_dotnet.Models;

namespace Cala_final_dotnet.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        // Initialize with default "To Celsius" selection
        var model = new TemperatureConverterModel 
        { 
            ConvertToScale = "Celsius" 
        };
        return View(model);
    }

    [HttpPost]
    public IActionResult Index(TemperatureConverterModel model)
    {
       
        model.Convert(); // Handle temperature conversion
        return View(model);
    }

    public IActionResult Questions()
    {
        return View(); // For the Questions page
    }
}