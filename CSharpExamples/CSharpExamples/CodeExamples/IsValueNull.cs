using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExamples.CodeExamples
{
    public class IsValueNull
    {
        public string IsNull()
        {
            Console.WriteLine("Checks if value is null:");
            string userInput = null;

            return userInput ??= "Value is null";
        }
    }
}
