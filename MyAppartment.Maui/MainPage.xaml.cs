using Microsoft.Extensions.Configuration;
using MyAppartment.Maui.Data;

namespace MyAppartment.Maui;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        var config = MauiProgram.Services.GetRequiredService<IConfiguration>();

        var settings = config.GetSection("Settings").Get<Settings>();
    }
}
