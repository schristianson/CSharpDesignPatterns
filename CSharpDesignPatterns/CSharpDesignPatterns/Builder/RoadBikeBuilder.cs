﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDesignPatterns;    // We need access to this namespace

namespace Builder
{
    public class RoadBikeBuilder : BikeBuilder
    { 
        /*
         * Class object of AbstractRoadBike
         * is asigned by the constructor and 
         * retrieved by the property Bicycle
         * */
        private AbstractRoadBike _roadBikeInProgress;   //"_" means private field

        /*
         * Property of RoadBikeBuilder used to return an object of IBicycle. 
         * This object is of type AbstractRoadBike 
         * that implements the IBicycle interface
         */
        public override IBicycle Bicycle
        {
            get
            {
                return _roadBikeInProgress;
            }
        }


        /*
         * Constructor of the class RoadBikeBuilder that takes a parameter of
         * AbstractRoadBike and assigns that parameter to the class field
         * _roadBikeInProgress
         */
        public RoadBikeBuilder(AbstractRoadBike roadBike)
        {
            this._roadBikeInProgress = roadBike;
        }

        /*
         * Method
         * public - Access Modifier
         * override - Used to define its behavior instead of 
         * the parent class that it extends
         * void - no return type
         */
        public override void BuildStreetTires()
        {
            Console.WriteLine ("Building Roadbike Street Tires.");
        }

        public override void BuildHandleBars()
        {
            Console.WriteLine("Building RoadBike Handlebars");
        }

    }
}
