using System;
using Proj_TDD_TestUnitario.CalculatorImp;
using Xunit;

namespace Proj_TDD_TestUnitario.CalculatorTest
{
    public class TestCalculator
    {
        [Fact]
        public void Test1()
        {
            Calculator calc = new Calculator() ;
            int result = calc.Add(1,2);
            Assert.Equal(3,result);
            // Given
        
            // When
        
            // Then
        }
    }

    internal class FactAttribute : Attribute
    {
    }
}