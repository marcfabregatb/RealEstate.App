using RealState.App.ViewModels;

namespace RealState.App.Views;

public partial class AgentProfilePage : ContentPage
{
	public AgentProfilePage()
	{
		InitializeComponent();
        BindingContext = MauiProgram.GetService<AgentProfileViewModel>();
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