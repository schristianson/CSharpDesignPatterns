﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Gearbox : ISpeedChanged
    {
        public Gearbox(Speedometer speed)
        {
            speed.VChanged += ValueHasChanged;
        }

        public void ValueHasChanged(object sender, EventArgs args)
        {
            Speedometer mySpeedometer = (Speedometer)sender;
            if (mySpeedometer.CurrentSpeed <= 10)
            {
                Console.WriteLine("Now in easy gear.");
            }
            else if (mySpeedometer.CurrentSpeed <= 20)
            {
                Console.WriteLine("Now in 2nd gear.");
            }
            else if (mySpeedometer.CurrentSpeed < 25)
            {
                Console.WriteLine("Now in 3rd gear");
            }
            else if (mySpeedometer.CurrentSpeed < 30)
            {
                Console.WriteLine("Now in 4th gear");
            }
        }
    }
}
