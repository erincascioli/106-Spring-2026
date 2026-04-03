using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvents_ClassDemo
{
    internal class ClassC
    {
        // Define a delegate
        public delegate int MathDelegate(int a, int b);

        private MathDelegate mathMethod;
        private int a;
        private int b;

        public ClassC(int a, int b)
        {
            mathMethod = Subtraction;
            this.a = a;
            this.b = b;
        }

        public int RunMathematics()
        {
            int answer = mathMethod(a, b);
            return answer;
        }

        public int Addition(int a, int b)
        {
            return a + b;
        }
        public int Subtraction(int a, int b)
        {
            return a - b;
        }
        public int Multiplication(int a, int b)
        {
            return a * b;
        }
        public int Division(int a, int b)
        {
            return a/b;
        }
    }
}
