using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface IFrog
    {
        double Weight { get; set; }
        string Colour { get; set; }
        bool IsPoisonous {  get; set; }
    }
}
