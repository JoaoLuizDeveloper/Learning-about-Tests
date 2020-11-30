using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestProject1
{
    [Collection("Customer")]
    public class CustomerClass
    {
        //[Fact]
        //public void CheckNameNotEmpty()
        //{
        //    var customer = new Customer();
        //    Assert.NotNull(customer.Name);
        //    Assert.False(string.IsNullOrEmpty(customer.Name));
        //}

        private readonly CustomerFixture _custumerFix;

        public CustomerClass(CustomerFixture customerFixture)
        {
            _custumerFix = customerFixture;
        }

        [Fact]
        public void CheckLegiForDiscount()
        {
            var customer = _custumerFix.Cust;
            Assert.InRange(customer.Age, 25, 40);
        }

        [Fact]
        public void GetOrdersByNameNotNull()
        {
            var custumer = _custumerFix.Cust;
            var exceptdetails =  Assert.Throws<ArgumentException>(() => custumer.GetOrdersByName(""));
            //exceptdetails.Message;
            Assert.Equal("Hello", exceptdetails.Message);
        }

        [Fact]
        public void LoyalCustomerForOrdersG100()
        {
            var customer = CustomerFactory.CreateCustumerInstance(103);
            //Assert.IsType(typeof(LoyalCustomer), customer);
            var loyalcustumer = Assert.IsType<LoyalCustomer>(customer);
            Assert.Equal(10, loyalcustumer.Discount);
        }
    }
}
