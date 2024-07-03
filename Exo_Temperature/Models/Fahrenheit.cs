using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Temperature.Models
{
    public struct Fahrenheit
    {
        public double Temperature;

        public Celsius ToCelsius() 
        {
            Celsius c;
            c.Temperature = Math.Round((Temperature - 32) / 1.8, 2);
            return c;
        }

    }
}
