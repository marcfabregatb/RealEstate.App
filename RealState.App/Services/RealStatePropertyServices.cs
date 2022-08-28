using RealState.App.Models;

namespace RealState.App.Services
{
    public class RealStatePropertyServices : IRealStatePropertyServices
    {
        public List<RealStateProperty> GetRealStateProperties()
        {
            var realtorDescription =
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Vitae justo eget magna fermentum iaculis. Sit amet nulla facilisi morbi tempus iaculis urna id volutpat. Viverra maecenas accumsan lacus vel facilisis.  \r\n\r\nAdipiscing bibendum est ultricies integer. Vitae tempus quam pellentesque nec nam aliquam sem et tortor. Fusce ut placerat orci nulla pellentesque dignissim enim sit.  Arcu risus quis varius quam quisque. Accumsan tortor posuere ac ut consequat semper viverra. ";
            var agent1 = new Agent() { Id = 1, Name = "Mia Saleta", Image = "Realtor1.jpg", Description = realtorDescription };
            var agent2 = new Agent() { Id = 2, Name = "Valentina Crossfusta", Image = "Realtor2.jpg", Description = realtorDescription };
            var categories = GetCategories();

            var realStateProperty = new List<RealStateProperty>()
            {
                new()
                {
                    Id = 1,
                    Title = "Pepe Studio",
                    Description = "Fully renovated and move in ready apartments are available for rent in downtown beside the River Valley at 10020 121st. Bachelor on the eight floor no balcony, carpet flooring and parking space ($900 per month $400 security deposit), and Two bedroom apartment on the main floor no balcony, vinyl flooring with one parking space ($1250 per month, security deposit $550). Heat, water and electricity are included in rent. Laundry inside the building, elevator, surveillance cameras, 24/7 resident management are available on site. Requirements: references from current landlord, employer (if applicable), proof of income and police criminal record check (fee is refundable). \r\nIf you are interested please reach me out to schedule you for a viewing",
                    Images = new List<string>(){"exterior1.jpg", "kitchen1.jpg", "livingroom1.jpg"},
                    Agent = agent1,
                    Category = categories[7],
                    Address = "6876 86 Street Edmonton",
                    Rooms = 1,
                    Bathrooms = 1,
                    SquareMeters = 83,
                    HasParking = false,
                    Price = 137000,
                    WalkScore = 40,
                    TransitScore = 50,
                    BikeScore = 60

                },
                new()
                {
                    Id = 2,
                    Title = "Manolo Mckenzy Townhouse" ,
                    Description = "3 bedrooms Duplex with living/dining, 2.5 bathrooms and fully finished basement. This house is located in Pollard Meadows / Mill woods Community. This house has following features. \r\n\tThis place boasts a beautiful open floor plan, lots of cabinets and large appliances (Washer, Dryer, Dishwasher, stove and double door Fridge). \r\n\tThe Spacious living room, beside the kitchen, has large bright windows to enjoy the sunshine. \r\n\tThe main floor has beautiful look with hardwood flooring in living, kitchen & dinning. While a half bath is conveniently located near the back entrance. \r\n\tThe upstairs has good size of 3 bedrooms with in suite large closets and one full bathroom. \r\n\tThe fully finished large basement has big hall bedroom with full bathroom and fire place, that provides lots of extra space for your guests and storage. \r\n\tWindow coverings and open green yard with walk out deck to enjoy BBQ and kids play area. \r\n\tWhile the detached oversized double garage will easily accommodate your vehicles and bikes, beside the garage there is space for RV as well.  \r\nPublic and catholic Schools are close to the community. While other Community features like pharmacy, family clinics, daycare, saloon, convenience store, gas station, banks and other facilities are only 2 minutes away. Easy access to 50 Street, White mud Drive, Anthony Henday, Highway II, walking trails and all sorts of great amenities to enjoy. Local ETS Bus Service and School Bus is also available. Pet negotiable but No smoking, Utilities are not included.",
                    Images = new List<string>(){"exterior5.jpg", "kitchen5.jpg", "livingroom5.jpg"},
                    Agent = agent2,
                    Category = categories[3],
                    Address = "64 20 Av W Edmonton",
                    Rooms = 2,
                    Bathrooms = 1,
                    SquareMeters = 350,
                    HasParking = false,
                    Price = 1,
                    WalkScore = 80,
                    TransitScore = 66,
                    BikeScore = 60
                },
                new()
                {
                    Id = 3,
                    Title = "Fernando Estanislau Apartment" ,
                    Description = "This 4-level split home comes with 3 bedrooms, 2 full baths and a den is located in the most desirable neighborhood of KEHEEWIN. The main floor features a bright living room, a spacious kitchen with plenty of cabinets & nice sized dining area.\r\nUpstairs have 2 bedrooms including the master bedroom and 4 pc bath. The lower level has a family room and 3 pc bath. The fully finished basement has a den, bedroom and laundry room. Huge yard with a double detached garage.\r\nClose to schools, transit, shopping, walking distance to LRT, and easy access to Anthony Henday and Whitemud.\r\n\r\nPROPERTY FEATURES:\r\nBedrooms: 3\r\nBathrooms: 2\r\nDen: 1\r\nBasement Development: Fully Finished\r\nBuilding Type: Detached Single Family\r\nFlooring: Carpet, Ceramic Tile, Laminate Flooring\r\nAppliances Included: Dryer, Refrigerator, Stove-Electric, Washer\r\nParking: Double Garage Detached\r\n\r\nSCHOOLS NEARBY:\r\nKeheewin School: (0.49 km)\r\nSteinhauer School: (1.21 km)\r\nEdmonton Academy: (1.39 km)\r\nSt. Teresa School: (1.56 km)\r\nSweet Grass School: (1.7 km)\r\nLearning Store (Blue Quill): (1.76 km)\r\nGeorge P. Nicholson School: (1.78 km)\r\nDuggan School: (1.96 km)\r\nAl Mustafa North Location: (2.23 km)\r\nSt. Augustine School: (2.27 km)",
                    Images = new List<string>(){"condo.jpg", "kitchen3.jpg", "livingroom3.jpg"},
                    Agent = agent1,
                    Category = categories[0],
                    Address = "5393 52 Av NW Edmonton",
                    Rooms = 2,
                    Bathrooms = 1,
                    SquareMeters = 120,
                    HasParking = false,
                    Price = 1,
                    WalkScore = 80,
                    TransitScore = 50,
                    BikeScore = 60
                },
                new()
                {
                    Id = 4,
                    Title = "Francis Kainer Basement",
                    Description = "Unique TULSI model by DPAD HOMES in CAVANAGH w/quick access to amenities, 41 Ave, EIA, HIGHWAY 2, FUTURE LRT, commercial strip, schools and public transportation. Contemporary Style Duplex 2 storey offering 1605 Sq. ft. w/ 9 Ceilings incl. BASEMENT, impressive luxury vinyl flooring, SS 6PC Appliance Package, GRANITE/QUARTZ CTPS, Kitchen CABS to ceiling, built-in corner pantry, full height tile backsplash, island w/overhang, triple pane windows, Tankless On-Demand Hot Water system, HRV & high efficiency furnace. Spacious floor plan w/sizable foyer, lavish & imposing family room w/electric fireplace feature wall, nook area & 2pc bath. Paint Grade Railing w/metal spindles on staircase. Upstairs has luxurious owners suite w/oversize walk in closet & 4pc bath w/stand-in-shower. Palatial Bonus Room, Upstairs Laundry & 2 largish beds, linen & full 3pc bath. PRICED TO SELL!! ",
                    Images = new List<string>(){"exterior7.jpg", "kitchen7.jpg", "livingroom7.jpg"},
                    Agent = agent2,
                    Category = categories[4],
                    Address = "9110 129 Street E Edmonton",
                    Rooms = 1,
                    Bathrooms = 1,
                    SquareMeters = 60,
                    HasParking = false,
                    Price = 95000,
                    WalkScore = 80,
                    TransitScore = 50,
                    BikeScore = 60
                },
                new()
                {
                    Id = 5,
                    Title = "Marc Fabregat House" ,
                    Description = "Lovely renovated home in the community of Kirkness! The main floor offers a spacious living room with rock feature wall, dining room and updated kitchen. The kitchen has refurbished oak cabinets, granite countertops and newer appliances. Upstairs you will find 2 good sized bedrooms and a renovated 3pc bath. The lower level offers a large family room and another 3pc bath. Basement is finished with a recreation room. Backyard is fully fence and landscaped with lovely stone walkway and patio, deck, shed and large greenhouse. Many upgrades have been done including shingles 2020, LED lightbulbs throughout, painted throughout inside/outside, deck replaced, all appliances 2020, roughed in for A/C, flooring throughout (except lower bath) and so much more! Has a great location walking distance to schools, parks and quick drive to Manning Town centre and the Anthony Henday. A must see property! ",
                    Images = new List<string>(){"exterior2.jpg", "kitchen2.jpg", "livingroom2.jpg"},
                    Agent = agent2,
                    Category = categories[2],
                    Address = "972 89 Av SW Edmonton",
                    Rooms = 4,
                    Bathrooms = 2,
                    SquareMeters = 440,
                    HasParking = true,
                    Price = 964000,
                    WalkScore = 80,
                    TransitScore = 50,
                    BikeScore = 90
                },
                new()
                {
                    Id = 6,
                    Title = "Mar Lloret Cotage",
                    Description = "Welcome to this 4 bedroom home with over 2000sf of living space on 2 floors. This home is situated within walking distance of 3 schools, short walk to WEM and easy access to the Whitemud or Anthony Henday for an easy commute to most anywhere in the city. This house has 3 bdrms on the main floor and an enormous 4th bdrm with ensuite in the basement, that is super bright with HUGE windows and being a Bi-level is doesn't feel like a basement. Huge yard with a double car garage make this ideal for a family or someone just wanting to get into the market with an affordable home. This is one of the best priced homes in the community and is sure to get some attention. ",
                    Images = new List<string>(){"exterior1.jpg", "kitchen1.jpg", "livingroom1.jpg"},
                    Agent = agent1,
                    Category = categories[1],
                    Address = "629 87 Av S Edmonton",
                    Rooms = 4,
                    Bathrooms = 2,
                    SquareMeters = 1200,
                    HasParking = true,
                    Price = 825000,
                    WalkScore = 75,
                    TransitScore = 10,
                    BikeScore = 60
                }
            };


            return realStateProperty;
        }

        public List<RealStateProperty> GetAgentProperties(int agentId)
        {
            var properties = GetRealStateProperties().Where(x => x.Agent.Id == agentId).ToList();
            return properties;
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
