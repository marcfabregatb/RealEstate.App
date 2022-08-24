using RealState.App.Models;

namespace RealState.App.Services
{
    public class HouseServices : IHouseServices
    {
        public List<House> GetHouses()
        {
            var houses = new List<House>();



            return houses;
        }

        public List<Category> GetCategories()
        {
            var categories = new List<Category>()
            {
                new(){Name = "Apartment", Image = "condo.jpg"},
                new(){Name = "Cotage", Image = "exterior1.jpg"},
                new(){Name = "House", Image = "exterior3.jpg"},
                new(){Name = "Townhouse", Image = "townhouse.jpg"},
                new(){Name = "Basement", Image = "exterior7.jpg"},
                new(){Name = "Residential", Image = "exterior3.jpg"},
                new(){Name = "Urban", Image = "urban.jpg"},
                new(){Name = "Studio", Image = "studio.jpg"}
            };



            return categories;
        }
    }
}
