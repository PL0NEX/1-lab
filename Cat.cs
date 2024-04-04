using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Cat: Mammal
    {
        public string Breed { get; set; }
        public double FurColour { get; set; }
        public Cat(double heightAtWithers, double weight, string Breed, string FutColour)
            : base(heightAtWithers, weight)
        {
            this.Breed = Breed;
            this.FurColour = FurColour;
        }
        public override void MLInfo()
        {
            Console.WriteLine($"Cat:Breed - {Breed},Height At Withers - {HeightAtWithers},Weight - {Weight}, Fur Colour - {FurColour}");
        }
    }
}
