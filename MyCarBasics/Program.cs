using System;
using CSharpFunamenetals.math;

namespace CSharpFunamenetals
{
 
    class Program
    {
        static void Main(string[] args)
        {
            var mycar = new MyCar
            {
                color = "blue",
                year = 2017,
                make = "Toyota",
                model = "Rav4"
            };
            
            mycar.CarInfo();

            Calculator calculator = new Calculator();
            var result = calculator.AddCarYears(3);
            Console.WriteLine("I just added 3 years to your car so it a " + result);
        }
    }
}
