#if IOS

using DemoServicios.Platforms.iOS.Servicios;

#elif ANDROID

using DemoServicios.Platforms.Android.Servicios;

#elif WINDOWS

using DemoServicios.Platforms.Windows.Servicios;

#endif

using DemoServicios.Servicios.Contractos;

namespace DemoServicios;

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

#if IOS

		builder.Services.AddScoped<IServicioSeguridad, SeguridadApple>();

#elif ANDROID

		builder.Services.AddScoped<IServicioSeguridad, SeguridadDroid>();

#elif WINDOWS

        builder.Services.AddScoped<IServicioSeguridad, SeguridadWindows>();

#endif

        return builder.Build();
	}
}
