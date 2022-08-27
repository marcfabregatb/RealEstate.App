using CommunityToolkit.Mvvm.ComponentModel;
using RealState.App.Models;

namespace RealState.App.ViewModels
{
    
    public partial class RealStatePropertyDetailViewModel : BaseViewModel, IQueryAttributable
    {
        [ObservableProperty]private RealStateProperty _realStateProperty;

        public RealStatePropertyDetailViewModel()
        {
            var a = 0;
        }


        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            RealStateProperty = query["RealStateProperty"] as RealStateProperty;

        }
    }
}
