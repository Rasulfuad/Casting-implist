using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting_implisit.task.Models
{
    internal class Celcius
    {
        public double Degree;


        public Celsius(double celcius)
        {
            Degree = celcius;
        }

        public static implicit operator Kelvin(Celsius celsius)
        {
            return new Kelvin(celsius.Degree + 273);
        }
    }
}
