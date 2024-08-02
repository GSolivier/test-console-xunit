using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_03
{
    public static class TemperatureConverter
    {
        public static double ConvertCelsiusToFahrenheit(double celsius)
        {
            double fahrenheit = ((celsius * 9) / 5) + 32;

            return fahrenheit;
        }
    }
}
