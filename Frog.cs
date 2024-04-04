using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Frog:IFrog
    {
        public double Weight { get; set; }
        public string Colour { get; set; }
        public bool IsPoisonous { get; set; }
       
        public Frog(double Weight,string Colour,bool IsPoisonous)
        {
            this.Weight = Weight;
            this.Colour = Colour;   
            this.IsPoisonous = IsPoisonous; 
        }
    }
}
