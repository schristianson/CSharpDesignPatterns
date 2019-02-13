using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    // RoadFrame implements the IBikeFrame interface
    public class RoadFrame : IBikeFrame
    {
        public string BikeFrameParts
        {
            get { return "Frame parts for Road Bike"; }
        }
    }
}
