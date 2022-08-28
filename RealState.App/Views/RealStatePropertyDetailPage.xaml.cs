using RealState.App.ViewModels;

namespace RealState.App.Views;

public partial class RealStatePropertyDetailPage : ContentPage
{
	public RealStatePropertyDetailPage()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(AgentProfilePage), typeof(AgentProfilePage));
        BindingContext = MauiProgram.GetService<RealStatePropertyDetailViewModel>();
    }

    private void TapGestureRecognizer_OnTapped(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }
}