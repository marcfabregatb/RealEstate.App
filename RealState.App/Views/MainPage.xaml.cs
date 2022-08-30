using RealEstate.App.ViewModels.Interfaces;

namespace RealEstate.App.Views;

public partial class MainPage : ContentPage
{

    public MainPage(IMainViewModel viewModel)
    {
        InitializeComponent();
        Routing.RegisterRoute(nameof(RealEstatePropertyDetailPage), typeof(RealEstatePropertyDetailPage));
        BindingContext = viewModel;
    }

    private void CollectionView_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (sender is CollectionView collectionView) collectionView.SelectedItem = null;
    }
}

