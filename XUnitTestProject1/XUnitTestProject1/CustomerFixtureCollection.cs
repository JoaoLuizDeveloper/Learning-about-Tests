using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestProject1
{
    //This definition Customer will aply in any class with this name
    [CollectionDefinition("Customer")]
    public class CustomerFixtureCollection : ICollectionFixture<CustomerFixture>
    {

    }
}
