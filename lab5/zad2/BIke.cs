using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.zad2
{
    public class Bike :IVehicle
    {
        public int MaxSpeed { get; set; }
        public void Start()
        {
            Console.WriteLine("Bike started");
        }
        public void Stop()
        {
            Console.WriteLine("Bike stopped");
        }
        public void Wheelie()
        {
            //jazda na jednym kole
            Console.WriteLine("Wheelie");
        }
        public Bike(int maxSpeed)
        {
            this.MaxSpeed = maxSpeed;
        }

    }
}
