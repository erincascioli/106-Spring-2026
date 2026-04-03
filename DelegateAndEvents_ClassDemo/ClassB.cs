using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvents_ClassDemo
{
    internal class ClassB
    {
        private string phrase;

        public ClassB(string phrase)
        {
            this.phrase = phrase;
        }

        public void PrintPhrase()
        {
            Console.WriteLine("My phrase is: " + phrase);
        }
    }
}
