namespace DelegateAndEvents_ClassDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ----------------------------------------------------------------
            // Object communication
            ClassB myB = new ClassB("This is a B!");
            ClassA myA = new ClassA(myB, "This is an A!");


            
            // ----------------------------------------------------------------
            // Using a delegate variable
            ClassC calculator = new ClassC(2, 5);
            int answer = calculator.RunMathematics();
            

            
            // ----------------------------------------------------------------
            // Inter class communication (observer pattern!)
            ClassD myD = new ClassD();
            ClassE myE = new ClassE();

            // MyE subscribes to MyD's event
            myD.MyEvent += myE.SomeMethod;
            myD.MyEvent += myD.SomeMethod;

            // Method that invokes the event
            myD.InvokeEvent();
        }
    }
}
