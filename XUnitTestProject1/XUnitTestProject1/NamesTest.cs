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
            Assert.Equal("joao Sa", result, ignoreCase: true);
            Assert.Contains("Sa", result, StringComparison.InvariantCultureIgnoreCase);
            Assert.StartsWith("Joao", result);
            Assert.EndsWith("Sa", result);
            Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+", result);

            //ignore case to ignore sensitive cases
        }

        [Fact]
        public void NickName_MustBeNull()
        {
            var names = new Names();

            Assert.Null(names.NickName);
            //names.NickName = "Joaozin";
            //Assert.NotNull(names.NickName);

        }

        [Fact]
        public void MakeFullName_AlwaysReturnValue()
        {
            var names = new Names();
            var result = names.MakeFullName("Joao", "Sa");
            Assert.NotNull(result);
            Assert.True(!string.IsNullOrEmpty(result));
        }
    }
}
