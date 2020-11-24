using System;
using Xunit;

namespace XUnitTestProject1
{
    public class NamesTest
    {
        [Fact]
        public void MakeFullNameTest()
        {
            var names = new Names();
            var result = names.MakeFullName("Joao", "Sa");
            Assert.Equal("Joao Sa", result);
        }
    }
}
