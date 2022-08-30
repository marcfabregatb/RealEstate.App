using RealEstate.App.ViewModels.Interfaces;

namespace RealEstate.App.Views;

public partial class AgentProfilePage : ContentPage
{
	public AgentProfilePage(IAgentProfileViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }

    private void TapGestureRecognizer_OnTapped(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }

    private void CollectionView_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (sender is CollectionView collectionView) collectionView.SelectedItem = null;
    }
}