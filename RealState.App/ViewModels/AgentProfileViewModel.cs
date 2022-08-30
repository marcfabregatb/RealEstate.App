using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RealEstate.App.Models;
using RealEstate.App.Services;
using RealEstate.App.ViewModels.Interfaces;

namespace RealEstate.App.ViewModels
{
    public partial class AgentProfileViewModel : BaseViewModel, IAgentProfileViewModel, IQueryAttributable
    {
        private readonly IRealEstatePropertyServices _realEstatePropertyServices;
        [ObservableProperty] private Agent _agentProfile;
        [ObservableProperty] private ObservableCollection<RealEstateProperty> _agentListings;

        public AgentProfileViewModel(IRealEstatePropertyServices realEstatePropertyServices)
        {
            _realEstatePropertyServices = realEstatePropertyServices;

        }
        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            AgentProfile = query["AgentProfile"] as Agent;
            LoadData();
        }

        private void LoadData()
        {
            AgentListings = new ObservableCollection<RealEstateProperty>(_realEstatePropertyServices.GetAgentProperties(AgentProfile.Id));
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
