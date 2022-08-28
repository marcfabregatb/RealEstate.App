using RealEstate.App.ViewModels;

namespace RealEstate.App.Views;

public partial class MainPage : ContentPage
{

    public MainPage()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(RealEstatePropertyDetailPage), typeof(RealEstatePropertyDetailPage));
        BindingContext = MauiProgram.GetService<MainViewModel>();
    }

    private void CollectionView_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (sender is CollectionView collectionView) collectionView.SelectedItem = null;
    }
}

