using Serilog;

var webAppBuilder = WebApplication.CreateBuilder(args); // Renamed 'builder' to 'webAppBuilder' for clarity

// Register MVC services (controllers with views)
webAppBuilder.Services.AddControllersWithViews();

// Configure Serilog for logging
webAppBuilder.Host.UseSerilog((hostContext, serviceProvider, loggerConfig) => {
    // Read logging configuration from appsettings.json and register services for dependency injection
    loggerConfig
        .ReadFrom.Configuration(hostContext.Configuration)  // Load settings from configuration (appsettings.json)
        .ReadFrom.Services(serviceProvider);  // Inject services into Serilog (e.g., IHttpContextAccessor)
});

var webApp = webAppBuilder.Build(); // Renamed 'app' to 'webApp' for more readability

// Serve static files (e.g., CSS, JavaScript, images) from wwwroot folder
webApp.UseStaticFiles();

// Enable routing for the application
webApp.UseRouting();

// Define default MVC route (HomeController's Index action as the default)
webApp.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"); // Optional 'id' parameter

// Start the application
webApp.Run();
