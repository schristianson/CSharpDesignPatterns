using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory;
using Builder;

namespace CSharpDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            BuilderPatternDemo();
           //AbstractFactoryDemo();
        }

        private static void BuilderPatternDemo()
        {
            AbstractMountainBike mountainBike = new
                Downhill(BikeColor.Green, new WideWheel(24));

            BikeBuilder builder = new MountainBikeBuilder(mountainBike);
            BikeDirector director = new MountainBikeDirector();
            IBicycle bicycle = director.Build(builder);
            Console.WriteLine(bicycle);
        }

        private static void AbstractFactoryDemo()
        {
            /*
             * Parent class object instance is created by its child class. This parent class can only see
             * methods that it created, that its child ues. Any child types created, cannot be seen unless
             * it was first created by the parent.
             * This class object factory can only see the methods that it created, even from its child
             */ 
            AbstractBikeFactory factory = new RoadBikeFactory();   //RoadBikeFactory constructor from its child class

            /* 
             * Create the Bike parts
             * Interface objects bikeFrame or bikeSeat are created. The "factory" object created
             * above calls the method that returns the interface to which it is assigned.
             * These Create methods create a new object of a Frame or Seat. This object can be of either 
             * Road or Mountain. In this case, the new objects of RoadFrame and RoadSeat, are created inside the 
             * RoadBikeFactory.
             */
            //This method returns an IBikeFrame (Method always has an open & closed parentheses)
            //Constructor is a class-level method, with no return type
            /*
             * CreateBikeFrame method
             * @returns IBikeFrame to object bikeFrame
             */
            /*
            * CreateBikeFrame method
            * @returns IBikeFrame to object bikeFrame
            */
            //interface objectofInterface = objectfromabove.method(); which is assigned from Right to Left
            IBikeFrame bikeFrame = factory.CreateBikeFrame();   // assigning that return value back to the interface
            IBikeSeat bikeSeat = factory.CreateBikeSeat();

            // Show what we created ... return back the properties through the interface object (above)... print it out
            /*
             * Interface object bikeFrame calls the property BikeFrameParts
             * bikeFrame was created from the class RoadFrame
             * The property BikeFrameParts uses the get to return
             * the string value from RoadFrame
             */
            /*
            * Interface object bikeSeat calls the property BikeSeatParts
            * bikeSeat was created from the class RoadSeat
            * The property BikeSeatParts uses the get to return
            * the string value from RoadSeat
            */
            Console.WriteLine(bikeFrame.BikeFrameParts);
            Console.WriteLine(bikeSeat.BikeSeatParts);
        }
    }
}
