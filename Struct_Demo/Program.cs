using System.Diagnostics;

namespace Struct_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Thing thing1 = new Thing();
            //Thing thing2 = new Thing();
            //Thing thing3 = thing1 + thing2;

            // ----------------------------------------------------------------
            // USING AN OVERLOADED OPERATOR
            // ----------------------------------------------------------------
            RectangleStruct firstRect = new RectangleStruct(0, 0, 10, 10);
            RectangleStruct secondRect = new RectangleStruct(0, 0, 2, 2);
            float area = firstRect + secondRect;
            Console.WriteLine(area);


            // ----------------------------------------------------------------
            // LOCALLY DECLARED STRUCTS
            // ----------------------------------------------------------------

            // This is a LOCALLY-DECLARED Rectangle object
            RectangleStruct rect1 = new RectangleStruct(2, 2, 10, 5);
            rect1.PrintRectangle();

            // Because it's locally declared (in the same scope as this Main method)
            //   I can modify any of its data directly with the assignment
            //   operator.
            // The Rectangle's X position is now 100!
            rect1.X = 100;
            rect1.PrintRectangle();


            // ----------------------------------------------------------------
            // REFERENCED STRUCTS
            // ----------------------------------------------------------------
            
            // When I add a struct object to a collection (list, stack, queue, etc.)
            //   the struct data is in the heap part of memory.
            List<RectangleStruct> myRects = new List<RectangleStruct>();
            myRects.Add(rect1);

            // If I try to modify any data, what's being returned is a COPY
            //   of the struct data on the heap.
            // And modifying the data with the assignment operator is really
            //   modifying a COPY of the struct, not the actual heap data.
            // So Visual Studio doesn't allow you to change the data!
            //myRects[0].Y = 500;    // NO Can't do this!

            // What you CAN do is the Copy-Alter-Replace method:
            // 1) Make a copy of the struct
            RectangleStruct rectCopy = myRects[0];
            // 2) Alter the data in the copy
            rectCopy.Y = 500;
            // 3) Replace the list's struct with this copy
            myRects[0] = rectCopy;

            // ----------------------------------------------------------------
            // TIMING OF STACK ALLOCATIONS VS HEAP ALLOCATIONS
            // ----------------------------------------------------------------
            // Allocating structs on the stack is a much faster process than 
            //   allocating objects onto the heap
            // Why?
            // Garbage collection is slower than stack deallocation
            // Allocation onto the heap is slower than stack allocation

            Stopwatch timer = new Stopwatch();

            timer.Start();
            for(int i = 0; i < 1000000; i++)
            {
                RectangleStruct newRect = new RectangleStruct(0, 0, 1, 1);
            }
            timer.Stop();

            Console.WriteLine(timer.Elapsed.TotalMilliseconds);


            timer.Restart();
            for (int i = 0; i < 1000000; i++)
            {
                RectangleClass newRect = new RectangleClass (0, 0, 1, 1);
            }
            timer.Stop();

            Console.WriteLine(timer.Elapsed.TotalMilliseconds);
        }        
    }
}
