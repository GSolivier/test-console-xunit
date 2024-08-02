using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculos.test
{
    public class CalculoUnitTest
    {
        //AAA: Act, Arrange, Assert
        // AAA: Agir, Origanizar, Assertivo

        [Fact]
        public void TestSumMethod() 
        { 
            //Arrange: Organizar
            var x1 = 5.9;
            var x2 = 4.1;

            var expectedValue = 10;

            //Act: Agir
            var sum = Calculo.Somar(x1, x2);

            //Assert: Provar

            Assert.Equal(expectedValue, sum);
        }

        [Fact]
        public void TestSubtractMethod()
        {
            //Arrange: Organizar
            var x1 = 4;
            var x2 = 3;

            var expectedValue = 1;

            //Act: Agir
            var sub = Calculo.Subtrair(x1, x2);

            //Assert: Provar

            Assert.Equal(expectedValue, sub);
        }

        [Fact]
        public void TestMultiplyMethod()
        {
            //Arrange: Organizar
            var x1 = 4;
            var x2 = 3;

            var expectedValue = 12;

            //Act: Agir
            var mul = Calculo.Multiplicar(x1, x2);

            //Assert: Provar

            Assert.Equal(expectedValue, mul);
        }

        [Fact]
        public void TestDivideMethod()
        {
            //Arrange: Organizar
            var x1 = 12;
            var x2 = 3;

            var expectedValue = 4;

            //Act: Agir
            var div = Calculo.Dividir(x1, x2);

            //Assert: Provar

            Assert.Equal(expectedValue, div);
        }
    }
}
