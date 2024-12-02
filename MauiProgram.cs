namespace LoginFlow;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
#if DEBUG
		builder.Logging.AddDebug();
#endif
		builder.Services.AddSingleton<MainViewModel>();

		builder.Services.AddSingleton<MainPage>();

		builder.Services.AddTransient<SampleDataService>();
		builder.Services.AddTransient<ListDetailDetailViewModel>();
		builder.Services.AddTransient<ListDetailDetailPage>();
		builder.Services.AddTransient<LoginViewModel>();

		builder.Services.AddSingleton<ListDetailViewModel>();

		builder.Services.AddSingleton<ListDetailPage>();

		builder.Services.AddSingleton<OptionsViewModel>();

		builder.Services.AddSingleton<OptionsPage>();

		builder.Services.AddSingleton<TestViewModel>();

		builder.Services.AddSingleton<TestPage>();
		builder.Services.AddSingleton<LoginPage>();

		return builder.Build();
	}
}
