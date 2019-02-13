using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDesignPatterns;    //need access to this namespace

namespace Builder
{
    public abstract class BikeBuilder
    {
        //define a property "Bicycle" & three methods
        // Property of IBicycle called Bicycle
        public abstract IBicycle Bicycle { get; }

        /*
         * virtual keword used to optionally override in child class; whereas, abstract forces an override
         * void means no return type
         * public is the access modifier - Everyone can see
         */
        public virtual void BuildStreetTires() { }
        public virtual void BuildWideTires() { }
        public virtual void BuildHandleBars() { }
    }
}
