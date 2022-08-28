using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RealState.App.Models;
using RealState.App.Services;

namespace RealState.App.ViewModels
{
    public partial class AgentProfileViewModel : BaseViewModel, IQueryAttributable
    {
        private readonly IRealStatePropertyServices _realStatePropertyServices;
        [ObservableProperty] private Agent _agentProfile;
        [ObservableProperty] private ObservableCollection<RealStateProperty> _agentListings;

        public AgentProfileViewModel(IRealStatePropertyServices realStatePropertyServices)
        {
            _realStatePropertyServices = realStatePropertyServices;

        }
        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            AgentProfile = query["AgentProfile"] as Agent;
            LoadData();
        }

        private void LoadData()
        {
            AgentListings = new ObservableCollection<RealStateProperty>(_realStatePropertyServices.GetAgentProperties(AgentProfile.Id));
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
