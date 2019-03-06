using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor;            // add folder into the using statement to pull from it 

namespace CSharpDesignPatterns
{
    public interface IWheel : IVisitable  // implement an interface within an interface
    {
        int Size { get; }
        bool IsWide { get; }

        void AcceptVisitor(IWheelVisitor visitor); //abstractwheel takes in this interface
    }
}
