using System;

namespace CSharpExamples.CodeExamples
{
    class ReverseTab
    {
        char[] c = { 'a', 'b', 'c', 'd', 'e', 'f', 'g' };
        
        public void WriteReverseTab() 
        {
            Console.WriteLine("After reversing using ^ operator:");

            int charLenght = c.Length;
            for (int i = 1; i <= charLenght; i++)
                Console.WriteLine(c[^i]);
        }
    }
}
