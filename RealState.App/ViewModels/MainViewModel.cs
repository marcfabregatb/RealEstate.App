using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RealEstate.App.Models;
using RealEstate.App.Services;
using RealEstate.App.ViewModels.Interfaces;

namespace RealEstate.App.ViewModels
{
    public partial class MainViewModel : BaseViewModel, IMainViewModel
    {
        private readonly IRealEstatePropertyServices _realEstatePropertyServices;
        [ObservableProperty] private ObservableCollection<Category> _categories;
        [ObservableProperty] private ObservableCollection<RealEstateProperty> _recommendations;

        public MainViewModel(IRealEstatePropertyServices realEstatePropertyServices)
        {
            _realEstatePropertyServices = realEstatePropertyServices;
            LoadData();
        }

        private void LoadData()
        {
            Categories = new ObservableCollection<Category>(_realEstatePropertyServices.GetCategories());
            Recommendations = new ObservableCollection<RealEstateProperty>(_realEstatePropertyServices.GetRealEstateProperties());
        }

        [RelayCommand]
        private async Task NavigateToDetail(RealEstateProperty property)
        {
            var navigationParameter = new Dictionary<string, object>
            {
                { "RealEstateProperty", property }
            };
            await Shell.Current.GoToAsync($"RealEstatePropertyDetailPage", navigationParameter);
        }
        
    }
}
