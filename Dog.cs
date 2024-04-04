using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Dog : Mammal
    {
        public string Breed { get; set; }
        public double HairLength { get; set; }
        public Dog(double heightAtWithers, double weight, string Breed, double HairLength)
            : base(heightAtWithers, weight)
        {
            this.Breed = Breed;
            this.HairLength = HairLength;
        }
        public override void MLInfo()
        {
           Console.WriteLine($"Dog:Breed - {Breed},Height At Withers - {HeightAtWithers},Weight - {Weight}, Hair Length - {HairLength} ");
        }

    }
}
