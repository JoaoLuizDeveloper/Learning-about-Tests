using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestProject1
{
    public class CustomerClass
    {
        //[Fact]
        //public void CheckNameNotEmpty()
        //{
        //    var customer = new Customer();
        //    Assert.NotNull(customer.Name);
        //    Assert.False(string.IsNullOrEmpty(customer.Name));
        //}

        [Fact]
        public void CheckLegiForDiscount()
        {
            var customer = new Customer();
            Assert.InRange(customer.Age, 25, 40);
        }

        [Fact]
        public void GetOrdersByNameNotNull()
        {
            var custumer = new Customer();
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
