using RealState.App.ViewModels;

namespace RealState.App.Views;

public partial class MainPage : ContentPage
{

    public MainPage()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(RealStatePropertyDetailPage), typeof(RealStatePropertyDetailPage));
        BindingContext = MauiProgram.GetService<MainViewModel>();
    }

    private void RecommendationCollectionView_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        this.RecommendationCollectionView.SelectedItem = null;
    }
}

