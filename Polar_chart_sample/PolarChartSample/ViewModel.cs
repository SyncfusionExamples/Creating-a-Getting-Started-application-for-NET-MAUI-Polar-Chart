using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolarChartSample
{
    public class ViewModel
    {
        public ObservableCollection<Model> PlantDetails { get; set; }
        public ViewModel()
        {
            PlantDetails = new ObservableCollection<Model>()
            {
            new Model(){ Direction = "North", Tree = 80, Flower = 42, Weed = 63},
            new Model(){ Direction = "NorthWest", Tree = 85, Flower = 40, Weed = 70},
            new Model(){ Direction = "West", Tree = 78 , Flower = 25, Weed = 45},
            new Model(){ Direction = "SouthWest", Tree = 90 , Flower = 40, Weed = 70},
            new Model(){ Direction = "South", Tree = 78 , Flower = 20, Weed = 47},
            new Model(){ Direction = "SouthEast", Tree = 83 , Flower = 45, Weed = 65},
            new Model(){ Direction = "East", Tree = 79 , Flower = 40, Weed = 58},
            new Model(){ Direction = "NorthEast", Tree = 88 , Flower = 28, Weed = 73},
            };
        }
    }
}
