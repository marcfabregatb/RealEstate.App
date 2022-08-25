using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using RealState.App.Models;
using RealState.App.Services;

namespace RealState.App.ViewModels
{
    public partial class MainViewModel : ObservableObject
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
        }
    }
}
