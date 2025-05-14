using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Cala_final_dotnet.Models;

namespace Cala_final_dotnet.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        // returns my new model as index route
        var model = new TemperatureConverterModel 
        { 
            ConvertToScale = "Celsius" 
        };
        return View(model);
    }

    //post response for temperature conversion
    [HttpPost]
    public IActionResult Index(TemperatureConverterModel model)
    {
       
        model.Convert(); // handle temperature conversion
        return View(model);
    }

    public IActionResult Questions()
    {
        return View(); // for the Questions page
    }
}