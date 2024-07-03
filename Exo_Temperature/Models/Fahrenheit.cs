using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Temperature.Models
{
    public struct Fahrenheit
    {
        private double _Temperature;

        public double Temperature { 
            get { return _Temperature; }
            set { _Temperature = value; }
        }

        public Celsius ToCelsius() 
        {
            Celsius c = new Celsius();
            c.Temperature = Math.Round((Temperature - 32) / 1.8, 2);
            return c;
        }

    }
}
