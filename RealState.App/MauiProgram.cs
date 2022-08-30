using CommunityToolkit.Maui;
using RealEstate.App.Services;
using RealEstate.App.ViewModels;
using RealEstate.App.ViewModels.Interfaces;
using RealEstate.App.Views;

namespace RealEstate.App;

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

                fonts.AddFont("Mulish-Italic.ttf", "MulishItalic");
                fonts.AddFont("Mulish.ttf", "Mulish");
                fonts.AddFont("fa-brands-400.ttf", "FAbrands400");
                fonts.AddFont("fa-regular-400.ttf", "FAregular400");
                fonts.AddFont("fa-solid-900.ttf", "FAsolid900");
            });

        builder.Services.AddTransient<IRealEstatePropertyServices, RealEstatePropertyServices>();
        
        builder.Services.AddTransient<AppShell>();
        builder.Services.AddTransient<MainPage>();
        builder.Services.AddTransient<RealEstatePropertyDetailPage>();
        builder.Services.AddTransient<AgentProfilePage>();

        builder.Services.AddTransient<IMainViewModel ,MainViewModel>();
        builder.Services.AddTransient<IRealEstatePropertyDetailViewModel, RealEstatePropertyDetailViewModel>();
        builder.Services.AddTransient<IAgentProfileViewModel, AgentProfileViewModel>();

        return builder.Build();
    }

}
