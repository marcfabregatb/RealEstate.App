using RealState.App.ViewModels;

namespace RealState.App.Views;

public partial class RealStatePropertyDetailPage : ContentPage
{
	public RealStatePropertyDetailPage()
	{
		InitializeComponent();
        BindingContext = MauiProgram.GetService<RealStatePropertyDetailViewModel>();
    }
}