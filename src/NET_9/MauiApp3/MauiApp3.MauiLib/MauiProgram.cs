using MauiApp3.Data;
using Microsoft.Extensions.Logging;

namespace MauiApp3
{
    public static partial class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder.UseMauiApp<App>()
                   .ConfigureFonts(fonts =>
                   {
                       fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                       fonts.AddFont("OpenSans-SemiBold.ttf", "OpenSansSemiBold");
                   });

            builder.Services.AddMauiBlazorWebView();
            builder.Services.AddSingleton(AppInfo.Current);
            builder.Services.AddSingleton<WeatherForecastService>();

#if DEBUG
            // Caution: Recommended to enable Developer Tools only for development!!!
            builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
