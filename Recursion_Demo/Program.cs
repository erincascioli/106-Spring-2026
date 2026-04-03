// Erin Cascioli
// 3/27/26
// Demo: Recursive examples

namespace Recursion_Demo
{
    internal class Program
    {
        public static char[] letters = { 'a', 'b', 'c', 'd', 'e' };
        public static List<int> myList = new List<int>();


        static void Main(string[] args)
        {
            int result = Factorial(5);


            Console.WriteLine("First implementation: ");
            PrintLetters("taco", 4);

            Console.WriteLine("Second implementation: ");
            PrintLetters2("taco", 4);

            //int counter = 5;
            //PrintSomeLetters(counter);

            //InsertItems(0);
            //foreach (int i in myList)
            //{
            //    Console.WriteLine(i);
            //}

            //AddNumbers(5);

            //Console.WriteLine();
            //int end = Fibonacci(6);
            //Console.WriteLine("Fibonacci value " + end);
            //Console.WriteLine();

            //double result = Exponent(2, 5);
            //Console.WriteLine(result);
        }


        public static int Factorial(int n)
        {
            if (n == 0)
                return 1;
            else if (n > 0)
                Factorial(n);
            else
                return - 1;
        }


        public static void PrintLetters(string letters, int c)
        {
            c--;
            if (c >= 0)
            {
                Console.WriteLine(letters[c]);
                PrintLetters(letters, c);
            }
        }


        public static void PrintLetters2(string letters, int c)
        {
            c--;
            if (c >= 0)
            {
                PrintLetters2(letters, c);
                Console.WriteLine(letters[c]);
            }
        }


        //Recursive method to print out the letters in an array in reverse order
        //Receives an index as a parameter
        //Internally, decrements that index until it reaches 0, 
        //  then runs the method recursively
        public static void PrintSomeLetters(int c)
        {
            c--;
            if (c >= 0)
            {
                Console.WriteLine(letters[c]);
                PrintSomeLetters(c);
            }
        }


        //Recursive method to add items to a list
        //Receives a number as an index
        //Internally, adds that number to the list until it reaches 20,
        //  meaning it adds the numbers 1 through 19
        public static void InsertItems(int c)
        {
            c++;
            if (c < 20)
            {
                myList.Add(c);
                InsertItems(c);
            }
            Console.WriteLine("Ran time " + c);
        }


        //Adds 2 numbers together recursively (doubles)
        public static int AddNumbers(int num)
        {
            int number = num + num;
            num--;
            if (num >= 0)
            {
                AddNumbers(num);
                Console.WriteLine("Called method.  Value: " + number);
            }
            return number;
        }


        // Find the number at a specific location within the Fibonacci sequence
        public static int Fibonacci(int iterations)
        {
            // BASE CASE
            if (iterations <= 1)
            {
                return iterations;
            }

            // RECURSIVE CASE
            else
            {
                return Fibonacci(iterations - 1) +
                       Fibonacci(iterations - 2);
            }
        }



        // Calculate a value raised to a power recursively.
        public static double Exponent(double n, int exp)
        {
            if (exp == 0)
            {
                return 1.0;
            }
            else if (exp > 0)
            {
                return n * Exponent(n, exp - 1);
            }
            else
            {
                throw new Exception();
            }
        }

        // Calculate a value raised to a power iteratively.
        public static double ExponentIterative(double n, int exp)
        {
            double result = n;
            for (int x = 1; x < exp; x++)
            {
                result *= result;
            }
            return result;
        }

    }
}
