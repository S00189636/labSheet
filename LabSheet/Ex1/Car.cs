using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Car
    {
        private string Make { get; set; }
        private string Model { get; set; }
        private string CurrentSpeed { get; set; }
        private double EngineSize { get; set; }

        public Car() { }
        public Car(string make, string model, string currentSpeed, double engineSize)
        {
            Make = make;
            Model = model;
            CurrentSpeed = currentSpeed;
            EngineSize = engineSize;
        }

        public void PrintProperties()
        {
            string format = "{0:-25}{1:-10}";
            Console.WriteLine(format,"Make: ",Make);
            Console.WriteLine(format, "Model: ", Model);
            Console.WriteLine(format, "CurrentSpeed: ", CurrentSpeed);
            Console.WriteLine(format, "EngineSize: ",EngineSize.ToString());
        }
    }
}
