using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Car
    {
        public string Make { get;  private set; }
        public string Model { get; private set; }
        public int CurrentSpeed { get; private set; }
        public double EngineSize { get; private set; }

        public Car() { }
        public Car(string make, string model, int currentSpeed, double engineSize)
        {
            Make = make;
            Model = model;
            CurrentSpeed = currentSpeed;
            EngineSize = engineSize;
        }

        public void PrintProperties()
        {
            string format = "{0:-35}{1:-10}";
            Console.WriteLine(format,"Make: ",Make);
            Console.WriteLine(format, "Model: ", Model);
            Console.WriteLine(format, "Current Speed: ", CurrentSpeed.ToString()+" KMPH");
            Console.WriteLine(format, "Engine Size: ",EngineSize.ToString());
            Console.WriteLine("------------------------------------------");
        }

        public void Accelerate(int amount)
        {
            CurrentSpeed += amount;
        }

        public void Accelerate()
        {
            Accelerate(10);
        }

        public override string ToString()
        {
            return Make.ToString() +"\n"+ Model.ToString()+"\n" + CurrentSpeed.ToString()+"\n" + EngineSize.ToString();
        }
    }
}
