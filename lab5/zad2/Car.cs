using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.zad2
{
    public class Car :IVehicle
    {
        public int MaxSpeed { get; set; }
        public void Start()
        {
            Console.WriteLine("Car started");
        }
        public void Stop()
        {
            Console.WriteLine("Car stopped");
        }
        public void OpenTrunk()
        {
            Console.WriteLine("Trunk opened");
        }
        public Car(int maxSpeed)
        {
            this.MaxSpeed = maxSpeed;
        }

    }
}
