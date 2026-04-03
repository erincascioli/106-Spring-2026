using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvents_ClassDemo
{
    internal class ClassA
    {
        private ClassB objectB;
        private string phrase;

        public ClassA(ClassB objB, string phrase)
        {
            this.objectB = objB;
            this.phrase = phrase;
        }

        public void PrintPhrase()
        {
            Console.WriteLine("My phrase is: " + phrase);
        }

        public void PrintObjectBPhrase()
        {
            objectB.PrintPhrase();
        }
    }
}
