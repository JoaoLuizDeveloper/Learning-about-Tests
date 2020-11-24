using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitTestProject1
{
    public class Customer
    {
        public int GetOrdersByName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Hello");
            }
            return 100;
        }
        public int Age => 35;
    }

    public class LoyalCustomer : Customer
    {
        public int Discount 
        { 
            get; 
            set; 
        }

        public LoyalCustomer()
        {
            Discount = 10;
        }

        public int GetOrdersByName(string name)
        {
            return 101;
        }
    }

    public static class CustomerFactory
    {
        public static Customer CreateCustumerInstance(int orderCount)
        {
            if (orderCount <= 100)
                return new Customer();
            else
                return new LoyalCustomer();
        }
    }
}
