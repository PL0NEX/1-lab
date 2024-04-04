using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class UssuriTiger : Mammal
    {
        public string Habitat { get; set; }
        public int RemainingInTheWild { get; set; }
        public UssuriTiger(double heightAtWithers, double weight, string Habitat, int RemainingInTheWild)
           : base(heightAtWithers, weight)
        {
            this.Habitat = Habitat;
            this.RemainingInTheWild =RemainingInTheWild;
        }
        public override void MLInfo()
        {
            Console.WriteLine($"UssuriTiger:Height At Withers - {HeightAtWithers},Habitat - {Habitat},Weight - {Weight}, Remaining In The Wild - {RemainingInTheWild} ");
        }
    }
}
