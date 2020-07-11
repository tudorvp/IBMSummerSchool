using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Seminar1.ProductionCode
{
    internal class Greeting
    {
        public Greeting()
        {
        }
        internal string Greet(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return "Hello, my friend.";
            }


            if (name == name.ToUpper())
            {
                return $"HELLO, {name.ToUpper()}!";
            }
            return $"Hello, {name}.";
        }

        internal string Greet(string[] names)
        {
            string result = String.Empty;
            if (names.Length == 2)
            {
                result = $"Hello, {names[0]} and {names[1]}.";
            }
            return result;
        }
    }
}