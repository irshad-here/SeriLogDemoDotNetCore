using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreSeriLogDemo.Controllers
{
    public class HomeController : Controller
    {
        // Dependency injection for the ILogger service to enable logging within this controller.
        private readonly ILogger<HomeController> _logger;

        // Constructor that accepts an ILogger<HomeController> and assigns it to the private field.
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger; // Store the injected logger instance for use in action methods.
        }

        // Action method that handles requests to "/Home/Index" and logs incoming parameters.
        public IActionResult Index(string param1, string param2)
        {
            // Log an informational message to indicate that the Index action has been called.
            _logger.LogInformation("Index action method of Home controller called.");

            // Log a detailed debug message to record the received parameters.
            _logger.LogDebug($"Following params are identified: param1: {param1} and param2: {param2}.");

            // Return the corresponding view (e.g., Views/Home/Index.cshtml).
            return View();
        }
    }
}
