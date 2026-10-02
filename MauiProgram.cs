using Microsoft.Extensions.Logging;
using TravelApp.ViewModels;
using TravelApp.Views;

namespace TravelApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("ElMessiri-Regular.ttf", "ElMessiriRegular");
                    fonts.AddFont("ElMessiri-Semibold.ttf", "ElMessiriSemibold");
                    fonts.AddFont("ElMessiri-Bold.ttf", "ElMessiriBold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddTransient<TravelViewModel>();
            builder.Services.AddTransient<TravelPage>();

            return builder.Build();
        }
    }
}
