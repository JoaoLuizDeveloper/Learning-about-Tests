using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Linq;

namespace XUnitTestProject1
{
    public static class TestDataShare
    {
        public static IEnumerable<Object[]> Is0dd0rEvenData{
            get
            {
                yield return new object[] { 1, true };
                yield return new object[] { 200, false };
            }
        }

        public static IEnumerable<Object[]> Is0dd0rEvenExternalData
        {
            get
            {
                var allLines = System.IO.File.ReadAllLines("IssOddOrEvenTestData.txt");
                return allLines.Select(x =>
                {
                    var lineSplit = x.Split(',');
                    return new object[] { int.Parse(lineSplit[0]), bool.Parse(lineSplit[1]) };
                });
            }
        }

    }
}
