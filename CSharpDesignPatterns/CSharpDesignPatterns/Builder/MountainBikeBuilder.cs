﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDesignPatterns;    // We need to access this namespace

namespace Builder
{
    public class MountainBikeBuilder : BikeBuilder
    {
        /*
         * Class object of AbstractMountainBike
         * is asigned by the constructor and 
         * retrieved by the property Bicycle
         * */
        private AbstractMountainBike _mountainBikeInProgress;   //"_" means private field

        /*
         * Property of MountainBikeBuilder used to return an object of IBicycle. 
         * This object is of type AbstractmountainBike 
         * that implements the IBicycle interface
         * */

        public override IBicycle Bicycle
        {
            get
            {
                return _mountainBikeInProgress;
            }
        }

        /*
         * Constructor of the class mountainBikeBuilder that takes a parameter of
         * AbstractmountainBike and assigns that parameter to the class field
         * _mountainBikeInProgress
         */

        public MountainBikeBuilder(AbstractMountainBike mountainBike)
        {
            this._mountainBikeInProgress = mountainBike;
        }
        /*
         * Method
         * public - Access Modifier
         * override - Used to define its behavior instead of 
         * the parent class that it extends
         * void - no return type
         */
        public override void BuildWideTires()
        {
            Console.WriteLine("Building MountainBike Wide Tires.");
        }

        public override void BuildHandleBars()
        {
            Console.WriteLine("Building MountainBike Handlebars");

        }
    }
}
