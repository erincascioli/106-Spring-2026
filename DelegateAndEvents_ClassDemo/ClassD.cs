using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvents_ClassDemo
{

    internal class ClassD
    {
        public delegate void DoSomething(string s);
        public event DoSomething MyEvent;

        public ClassD()
        {
            
        }

        public void SomeMethod()
        {
            Console.WriteLine("Running a method in Class D!");
        }

        public void SomeMethod(string phrase)
        {
            Console.WriteLine("Running a method in Class D! The phrase is " + phrase);
        }

        public void InvokeEvent()
        {
            if(MyEvent != null)
            {
                MyEvent("Invoked!");
            }
        }
    }
}
