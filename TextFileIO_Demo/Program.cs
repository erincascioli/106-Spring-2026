
// Erin Cascioli
// 1/16/26
// Demo: Text File IO with object instantiation


// Namespace where file reading/writing comes from
// using System.IO;

namespace TextFileIO_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare the reader so its in scope within the try/finally blocks
            StreamReader reader = null!;

            // List of Enemy objects will contain Enemies instantiated with data from the 
            //   EnemyData.txt text file.
            List<Enemy> enemyList = new List<Enemy>();

            try
            {
                // Instantiate the reader
                reader = new StreamReader("../../../EnemyData.txt");

                // lineFromFile will contain every line read in from the text file.
                string lineFromFile = "";

                // Continually read lines from the file until the data runs out
                while( (lineFromFile = reader.ReadLine()!) != null )
                {
                    // Lines are serialized like this: "Name,Health,Attack"
                    // Split the data into an array of strings to be able to extract
                    //   data from the line, independently, and parsing where needed.
                    string[] splitData = lineFromFile.Split(',');

                    // Instantiate enemies and add to the Enemy list
                    Enemy someDude = new Enemy(
                        splitData[0],                   // Name
                        int.Parse(splitData[2]),        // Attack
                        int.Parse(splitData[1]));       // Health

                    enemyList.Add(someDude);
                }
            }
            catch(Exception error)
            {
                Console.WriteLine("Error: " + error.Message);
            }
            finally
            {
                // As long as the reader was properly instantiated, close the stream
                //   for other processes to utilize later.
                if(reader != null)
                {
                    reader.Close();
                }
            }

            // Loop through Enemy objects, printing them out, to confirm
            //   correct instantiation
            foreach(Enemy badGuy in enemyList)
            {
                Console.WriteLine(badGuy);
            }
        }
    }
}
