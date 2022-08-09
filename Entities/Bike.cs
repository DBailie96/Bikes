using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Bike
    {
        public int BikeID { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public int Displacement { get; set; }

        public double Price { get; set; }

        public string Terrain { get; set; }

        public string Description { get; set; }
    }
}
