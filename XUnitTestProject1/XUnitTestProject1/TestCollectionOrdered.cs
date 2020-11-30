using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;
using System.Collections.Generic;
using System.Linq;

namespace XUnitTestProject1
{
    public class TestCollectionOrdered : ITestCollectionOrderer
    {
        public IEnumerable<ITestCollection> OrderTestCollections(IEnumerable<ITestCollection> testCollections)
        {
            return testCollections.OrderBy(x=> x.DisplayName);
        }
    }
}
