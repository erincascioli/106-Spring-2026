
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
                //reader = new StreamReader("../../../EnemyData.txt");
                reader = new StreamReader("../../../aaaaa.txt");

                // lineFromFile will contain every line read in from the text file.
                string lineFromFile = "";

                // Continually read lines from the file until the data runs out
                while ((lineFromFile = reader.ReadLine()!) != null)
                {
                    string[] splitData = lineFromFile.Split(',');

                    Enemy newGuy = new Enemy(
                        splitData[0],                   // Name
                        int.Parse(splitData[1]),        // Attack
                        int.Parse(splitData[2]));       // Health

                    enemyList.Add(newGuy);
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
