using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Temperature.Models
{
    public struct Celsius
    {
        public double Temperature { get; set; }

        public Fahrenheit ToFahrenheit()
        {
            Fahrenheit f = new Fahrenheit();
            f.Temperature = Math.Round((Temperature * 1.8 ) + 32, 2);
            return f;
        }
    }
}
