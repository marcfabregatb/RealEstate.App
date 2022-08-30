using RealEstate.App.ViewModels.Interfaces;

namespace RealEstate.App.Views;

public partial class RealEstatePropertyDetailPage : ContentPage
{
	public RealEstatePropertyDetailPage(IRealEstatePropertyDetailViewModel viewModel)
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(AgentProfilePage), typeof(AgentProfilePage));
        BindingContext = viewModel;
    }

    private void TapGestureRecognizer_OnTapped(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }
}