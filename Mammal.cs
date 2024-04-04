using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Mammal
    {
        public double HeightAtWithers{ get; set;  }
        public double Weight { get; set; }
        public Mammal(double heightAtWithers, double weight)
        {
            HeightAtWithers = heightAtWithers;
            Weight = weight;
        }
        public abstract void MLInfo();
    }
}
