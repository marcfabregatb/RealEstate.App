using RealEstate.App.Models;

namespace RealEstate.App.Services
{
    public interface IRealEstatePropertyServices
    {
        List<RealEstateProperty> GetRealEstateProperties();
        List<RealEstateProperty> GetAgentProperties(int agentId);
        List<Category> GetCategories();
    }
}
