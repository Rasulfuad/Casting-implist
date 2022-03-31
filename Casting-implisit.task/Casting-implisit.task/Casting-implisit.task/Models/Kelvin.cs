using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting_implisit.task.Models
{
    internal class Kelvin
    {
        public double Degree { get; set; }


        public Kelvin(double kelvin)
        {
            Degree = kelvin;
        }
    }
}