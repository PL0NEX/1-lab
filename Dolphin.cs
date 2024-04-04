using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Dolphin : Mammal
    {
        public double Length { get; set; }
        public int Age { get; set; }
       
        public Dolphin(double length,double weight, int age)
            : base(0, weight)
        {
            Length = length;
            Age = age;
        }
        public override void MLInfo()
        {
            Console.WriteLine($"Dolphin:Length - {Length},Weight - {Weight},Age - {Age} ");
        }
    }
}
