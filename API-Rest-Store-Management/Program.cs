using API_Rest_Store_Management;
using Serilog;
using Serilog.Events;

Log.Logger = new LoggerConfiguration()
            .WriteTo.File(
                path: "logs\\log-.txt",
                outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}",
                rollingInterval: RollingInterval.Day,
                restrictedToMinimumLevel: LogEventLevel.Information
            ).CreateLogger();
try
{
    Log.Information("Application Is Starting");
    var builder = WebApplication.CreateBuilder(args)
    .UseStartup<Startup>();
}
catch (Exception ex)
{
    Log.Fatal(ex, "Application Failed to start");
}
finally
{
    Log.CloseAndFlush();
}