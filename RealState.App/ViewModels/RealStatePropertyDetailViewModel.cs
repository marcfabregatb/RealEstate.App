using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RealState.App.Models;

namespace RealState.App.ViewModels
{
    
    public partial class RealStatePropertyDetailViewModel : BaseViewModel, IQueryAttributable
    {
        [ObservableProperty]private RealStateProperty _realStateProperty;

        public RealStatePropertyDetailViewModel()
        {

        }


        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            RealStateProperty = query["RealStateProperty"] as RealStateProperty;
        }

        [RelayCommand]
        private async void NavigateToAgentProfile(Agent agentProfile)
        {
            var navigationParameter = new Dictionary<string, object>
            {
                { "AgentProfile", agentProfile }
            };
            await Shell.Current.GoToAsync("AgentProfilePage", navigationParameter);
        }
    }
}
