namespace GenericsIndexers_Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IndexedClass indexedClass = new IndexedClass();
            int someVal = indexedClass[1];


            MyCustomDataStructure<int> mcdsInt = new MyCustomDataStructure<int>();
            mcdsInt.Add(5);
            mcdsInt.GetData(4);
            int data = mcdsInt[9];

            MyCustomDataStructure<string> mcds = new MyCustomDataStructure<string>();
            mcds.Add("bad data");
            mcds.Add("noodle");
            mcds.Add("cheese");
            mcds.Add("sandwich");

            Console.Write("Enter the index: ");
            int userIndex = int.Parse(Console.ReadLine()!);

            while(userIndex < 0 || userIndex >= mcds.Size)
            {
                // Reprompt user for new index
            }

            try
            {
                Console.WriteLine(mcds.GetData(userIndex));
            }
            catch(Exception error)
            {
                Console.WriteLine("Error: " + error.Message);
            }


            // NOOOOOOOOOOOOOOOOOOOOOOO!
            //mcds.MyData[0] = null!;
            //mcds.MyData[1] = null!;
        }
    }
}
