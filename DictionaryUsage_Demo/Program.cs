
// Erin Cascioli
// 2/6/26
// Demo: Dictionary Usage

namespace DictionaryUsage_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare the dictionary that maps a string to a string
            Dictionary<string, string> favoriteCandy = new Dictionary<string, string>();

            // Add data with the Add method
            favoriteCandy.Add("Emmett", "Three Musketeers");
            favoriteCandy.Add("Kai", "Twix");
            favoriteCandy.Add("Adon", "Skittles");
            favoriteCandy.Add("Avery", "Bottlecaps");
            favoriteCandy.Add("Greg", "100 Grand");

            // OR you can add data via direct instantiation
            favoriteCandy["Henry"] = "Reese's Pieces";
            favoriteCandy["Nicora"] = "Peach Rings";

            // Count is the number of entries (key-value pairs) in the dictionary.
            Console.WriteLine($"Number of entries is {favoriteCandy.Count}");

            // Determine whether a key exists before retrieval using the ContainsKey method.
            if (favoriteCandy.ContainsKey("Nicora"))
            {
                string nicoraFave = favoriteCandy["Nicora"];
                Console.WriteLine("Nicora's favorite candy is " + favoriteCandy["Nicora"]);
            }

            // This prevents a KeyNotFoundException!
            if (favoriteCandy.ContainsKey("Bob"))
            {
                string bobFave = favoriteCandy["Bob"];
                Console.WriteLine("Bob's favorite candy is " + favoriteCandy["Bob"]);
            }

            // Remove a key-value pair from the dictionary.
            favoriteCandy.Remove("Bob");

            // NOT the strength of a dictionary! But can do it if you reeeeeeally have to.
            foreach(KeyValuePair<string, string> pair in favoriteCandy)
            {
                Console.WriteLine($"This KVP has: {pair.Key} {pair.Value}");
            }
        }
    }
}
