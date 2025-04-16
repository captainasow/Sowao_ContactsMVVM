using Sowao_ContactsMVVM.ViewModels;
using Microsoft.Extensions.Logging;

namespace Sowao_ContactsMVVM;

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
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif
			builder.Services.AddSingleton<ContactsViewModel>();
            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<ContactsPage>();
            builder.Services.AddSingleton<ContactDetailsPage>();

			return builder.Build();
	}
}
