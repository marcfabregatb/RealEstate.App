using RealState.App.Models;

namespace RealState.App.Services
{
    public interface IHouseServices
    {
        List<House> GetHouses();
        List<Category> GetCategories();
    }
}
