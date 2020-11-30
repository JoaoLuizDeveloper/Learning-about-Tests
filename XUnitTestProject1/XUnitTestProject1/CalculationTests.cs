using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace XUnitTestProject1
{
    public class CalculatorFixture : IDisposable
    {
        private readonly ITestOutputHelper _testOutputHelper;
        private readonly CalculatorFixture _calculatorFixture;
        private readonly MemoryStream memoryStream;

        public CalculatorFixture(ITestOutputHelper testOutputHelper, CalculatorFixture calculatorFixture)
        {
            _testOutputHelper = testOutputHelper;
            _calculatorFixture = calculatorFixture;
            _testOutputHelper.WriteLine("Constructor");

            memoryStream = new MemoryStream();
        }
        public Calculations calc => new Calculations();

        public void Dispose()
        {
            memoryStream.Close();
        }
    }

    public class CalculationTests : IClassFixture<CalculatorFixture>
    {
        private readonly ITestOutputHelper _testOutputHelper;
        private readonly CalculatorFixture _calculatorFixture;
        private readonly MemoryStream memoryStream;

        public CalculationTests(ITestOutputHelper testOutputHelper, CalculatorFixture calculatorFixture)
        {
            _testOutputHelper = testOutputHelper;
            _calculatorFixture = calculatorFixture;
            _testOutputHelper.WriteLine("Constructor");

            memoryStream = new MemoryStream();
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboDoesNotIncludeZero()
        {
            _testOutputHelper.WriteLine("FiboDoesNotIncludeZero");
            var calc = _calculatorFixture.calc;
            Assert.All(calc.FiboNumbers, n => Assert.NotEqual(0, n));
        }
        
        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboIncludes13()
        {
            var calc = _calculatorFixture.calc;
            Assert.Contains(13, calc.FiboNumbers);
        }
        
        [Fact]
        [Trait("Category", "Fibo")]
        public void CheckCollection()
        {
            //To describe a message about the test
            _testOutputHelper.WriteLine("CheckCollection. test starting at {0}", DateTime.Now);
            var calc = new Calculations();
            var expectCollection = new List<int>() { 1, 1, 2, 3, 5, 8, 13 };
            Assert.Equal(expectCollection, calc.FiboNumbers);
        }
        
        [Fact]
        public void FiboDoesNotContain4()
        {
            var calc = new Calculations();
            Assert.DoesNotContain(4, calc.FiboNumbers);
        }



        [Fact]
        public void Add_GivenTwoIntValues_ReturnsInt()
        {
            var calc = new Calculator();
            var result = calc.Add(1, 2);
            Assert.Equal(3, result);
        }

        [Fact]
        public void Add_GivenTwoDoubleValues_ReturnsDouble()
        {
            var calc = new Calculator();
            var result = calc.AddDouble(1.5, 3.55);
            //Assert.Equal(4, result);
            Assert.Equal(5.05, result, 1);
        }

        [Fact]
        public double Add_GivenReturnsDouble()
        {
            var calc = new Calculator();
            var result = calc.AddDouble(1.5, 2.5);
            Assert.Equal(4, result);

            return result;
        }
    }
}
