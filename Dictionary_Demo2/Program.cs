namespace Dictionary_Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // char --> int
            // place in the alphabet
            Dictionary<char, int> alphabet = new Dictionary<char, int>();

            // Add data
            alphabet.Add('a', 1);
            alphabet.Add('b', 2);
            alphabet['c'] = 3;
            //alphabet['c'] = 4;
            alphabet['d'] = 4;
            
            // Nope!  
            //alphabet.Add('c', 5);

            Console.WriteLine(alphabet['a']);
            Console.WriteLine(alphabet['b']);
            Console.WriteLine(alphabet['c']);
            Console.WriteLine(alphabet['d']);

            // O(1)
            if (alphabet.ContainsKey('e'))
            {
                Console.WriteLine(alphabet['e']);
            }

            // O(n)
            if(alphabet.ContainsValue(68))
            {
                Console.WriteLine("Found it!");
            }

            // Can do this.
            foreach(KeyValuePair<char, int> kvp in alphabet)
            {
                char pairKey = kvp.Key;
                int pairValue = kvp.Value;
                Console.WriteLine($"{pairKey} {pairValue}");
            }

            alphabet.Remove('f');
            
        }
    }
}
