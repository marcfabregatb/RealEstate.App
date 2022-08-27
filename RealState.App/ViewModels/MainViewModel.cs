using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RealState.App.Models;
using RealState.App.Services;

namespace RealState.App.ViewModels
{
    public partial class MainViewModel : BaseViewModel
    {
        private readonly IRealStatePropertyServices _realStatePropertyServices;
        [ObservableProperty] private ObservableCollection<Category> _categories;
        [ObservableProperty] private ObservableCollection<RealStateProperty> _recommendations;

        public MainViewModel(IRealStatePropertyServices realStatePropertyServices)
        {
            _realStatePropertyServices = realStatePropertyServices;
            LoadData();
        }

        private void LoadData()
        {
            Categories = new ObservableCollection<Category>(_realStatePropertyServices.GetCategories());
            Recommendations = new ObservableCollection<RealStateProperty>(_realStatePropertyServices.GetRealStateProperties());
            var navigationParameter = new Dictionary<string, object>
            {
                { "RealStateProperty", Recommendations.FirstOrDefault() }
            };
            //Shell.Current.GoToAsync($"RealStatePropertyDetailPage", navigationParameter);

        }

        [RelayCommand]
        private async Task NavigateToDetail(RealStateProperty property)
        {
            var navigationParameter = new Dictionary<string, object>
            {
                { "RealStateProperty", property }
            };
            await Shell.Current.GoToAsync($"RealStatePropertyDetailPage", navigationParameter);
        }

    }
}
