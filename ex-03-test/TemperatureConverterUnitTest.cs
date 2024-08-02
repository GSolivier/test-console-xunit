using ex_03;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_03_test
{
    public class TemperatureConverterUnitTest
    {
        [Fact]
        public void TemperatureConverterTest() 
        {
            var celsius = 30;
            var expectedValue = 86;

            var fahrenheit = TemperatureConverter.ConvertCelsiusToFahrenheit(celsius);

            Assert.Equal(expectedValue, fahrenheit);
        }
    }
}
