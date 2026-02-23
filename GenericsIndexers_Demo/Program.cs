// Erin Cascioli
// 1/23/26
// Demo: Generics and Indexer properties


namespace GenericsIndexers_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ------------------------------------------------------------------------------------
            // Access one of the three fields of the class
            // ------------------------------------------------------------------------------------
            IndexedDataStructure ids = new IndexedDataStructure();
            Console.WriteLine(ids[3]);



            // ------------------------------------------------------------------------------------
            // Instantiate my custom data structure
            // ------------------------------------------------------------------------------------
            MyDataStructure<string> myDSList = new MyDataStructure<string>();
            MyDataStructure<bool> myDSList2 = new MyDataStructure<bool>();
            MyDataStructure<char> myDSList3 = new MyDataStructure<char>();

            // ------------------------------------------------------------------------------------
            // Use methods of the DS class to enter data
            // ------------------------------------------------------------------------------------
            myDSList.Add("zero");
            myDSList.Add("one");
            myDSList.Add("Out of range, sorry");

            // ------------------------------------------------------------------------------------
            // Using properties
            // ------------------------------------------------------------------------------------
            // With the Size property (it's a good property!), we can access amount of data
            //   in the data structure.
            Console.WriteLine("Size? " + myDSList.Size);

            // With the BAD property, we could do this:
            //myDSList.ClassData[0] = "poop";

            // ------------------------------------------------------------------------------------
            // Retrieve data from the data structure
            // ------------------------------------------------------------------------------------
            // Variable needed for retrieving data from the list
            string data = "";

            // Calling a method that potentially throws an exception? Call it in a try/catch.
            try
            {
                // Both the GetData method and the indexer allow access to data
                // However, the indexer uses [] notation while the other is a method.
                data = myDSList.GetData(13);
                data = myDSList[13];
                myDSList[0] = "sgxdhd";
            }
            catch(Exception error)
            {
                Console.WriteLine("Exception thrown! " + 
                    error.Message);
            }

            // Verify data was retrieved
            Console.WriteLine(data);
        }
    }
}
