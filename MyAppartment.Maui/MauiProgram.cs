using System.Globalization;
using System.Reflection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using MyAppartment.Maui.Data;

namespace MyAppartment.Maui;
public static class MauiProgram
{
    public static IServiceProvider Services { get; private set; }

    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            });

        var a = Assembly.GetExecutingAssembly();
        using var stream = a.GetManifestResourceStream("MyAppartment.Maui.appsettings.json");

        var config = new ConfigurationBuilder()
            .AddJsonStream(stream)
            .Build();

        builder.Configuration.AddConfiguration(config);

        builder.Services.AddMauiBlazorWebView();

#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
		builder.Logging.AddDebug();
#endif

        builder.Services.AddSingleton<WeatherForecastService>();
        builder.Services.AddSingleton<IDialogService, DialogService>();
        builder.Services.AddLocalization();
        builder.Services.AddHttpClient();

        Thread.CurrentThread.CurrentCulture = new CultureInfo("he-IL");
        Thread.CurrentThread.CurrentUICulture = new CultureInfo("he-IL");
        CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("he-IL");
        CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("he-IL");

        var app = builder.Build();

        Services = app.Services;

        return app;
    }
}
