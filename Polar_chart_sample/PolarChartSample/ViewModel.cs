using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolarChartSample
{
    public class PlantViewModel
    {
        public ObservableCollection<PlantModel> PlantDetails { get; set; }
        public PlantViewModel()
        {
            PlantDetails = new ObservableCollection<PlantModel>()
            {
                new PlantModel(){ Direction = "North", Tree = 80, Flower = 42, Weed = 63},
                new PlantModel(){ Direction = "NorthEast", Tree = 85, Flower = 40, Weed = 70},
                new PlantModel(){ Direction = "East", Tree = 78 , Flower = 47, Weed = 65},
                new PlantModel(){ Direction = "SouthEast", Tree = 90 , Flower = 40, Weed = 70},
                new PlantModel(){ Direction = "South", Tree = 78 , Flower = 27, Weed = 47},
                new PlantModel(){ Direction = "SouthWest", Tree = 83 , Flower = 45, Weed = 65},
                new PlantModel(){ Direction = "West", Tree = 79 , Flower = 40, Weed = 58},
                new PlantModel(){ Direction = "NorthWest", Tree = 88 , Flower = 38, Weed = 73}
            };
        }
    }
}
