using RealEstate.App.ViewModels;

namespace RealEstate.App.Views;

public partial class RealEstatePropertyDetailPage : ContentPage
{
	public RealEstatePropertyDetailPage()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(AgentProfilePage), typeof(AgentProfilePage));
        BindingContext = MauiProgram.GetService<RealEstatePropertyDetailViewModel>();
    }

    private void TapGestureRecognizer_OnTapped(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }
}