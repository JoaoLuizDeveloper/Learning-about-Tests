using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestProject1
{
    [Collection("Customer")]
    public class CustomerDetailsTest
    {
        private readonly CustomerFixture _custumerFix;

        public CustomerDetailsTest(CustomerFixture customerFixture)
        {
            _custumerFix = customerFixture;
        }

        [Fact]
        public void GetFullName_GivenFirstandLastName()
        {
            var customer = _custumerFix.Cust;

            Assert.Equal("Joao Luiz", customer.GetFullName("Joao", "Luiz"));
        }
    }
}