using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using RealState.App.Models;
using RealState.App.Services;

namespace RealState.App.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        private readonly IHouseServices _houseServices;
        [ObservableProperty] private ObservableCollection<Category> _categories;

        public MainViewModel(IHouseServices houseServices)
        {
            _houseServices = houseServices;
            LoadData();
        }

        private void LoadData()
        {
            Categories = new ObservableCollection<Category>(_houseServices.GetCategories());
        }
    }
}
