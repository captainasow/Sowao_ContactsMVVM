using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Hosting;
using Microsoft.Extensions.DependencyInjection;

// Alias namespaces to prevent ambiguity
using Views = Sowao_ContactsMVVM.Views;
using ViewModels = Sowao_ContactsMVVM.ViewModels;

namespace Sowao_ContactsMVVM
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
                });

            // Register ViewModels
            builder.Services.AddSingleton<ViewModels.ContactsViewModel>();

            // Register Pages
            builder.Services.AddSingleton<Views.MainPage>();
            builder.Services.AddSingleton<Views.ContactsPage>();
            builder.Services.AddSingleton<Views.ContactsDetailPage>();

            return builder.Build();
        }
    }
}