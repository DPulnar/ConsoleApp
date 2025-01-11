using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.zad2
{
    public interface IVehicle
    {
        int MaxSpeed { get; set; }
        void Start();
        void Stop();
    }
}
