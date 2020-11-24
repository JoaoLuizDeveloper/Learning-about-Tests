using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitTestProject1
{
    public class Names
    {
        public string NickName { get; set; }

        public string MakeFullName(string FirstName, string LastName)
        {
            return $"{ FirstName}-{LastName}";
        }
    }
}
