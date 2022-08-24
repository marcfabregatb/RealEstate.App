using RealState.App.ViewModels;

namespace RealState.App.Views;

public partial class MainPage : ContentPage
{

    public MainPage()
	{
		InitializeComponent();

        BindingContext = MauiProgram.GetService<MainViewModel>();
    }
	
}

