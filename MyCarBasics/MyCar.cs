using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFunamenetals
{ 
    public class MyCar
    {
    public string color;
    public int year;
    public string make;
    public string model;

        public void CarInfo()
        {
        Console.WriteLine("The color of your car is " + color);
        Console.WriteLine("It is a " + year + " " + make + " " + model);
        }

    }
}