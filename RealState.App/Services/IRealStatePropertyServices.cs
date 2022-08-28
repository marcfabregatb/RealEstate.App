using RealState.App.Models;

namespace RealState.App.Services
{
    public interface IRealStatePropertyServices
    {
        List<RealStateProperty> GetRealStateProperties();
        List<RealStateProperty> GetAgentProperties(int agentId);
        List<Category> GetCategories();
    }
}
