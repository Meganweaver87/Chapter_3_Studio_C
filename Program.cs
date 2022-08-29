// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

namespace Studio
{
    class Program
    {

        static void Main(string[] args)
        {
            string loremIpsum = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";
            char[] charsInString = loremIpsum.ToCharArray();
            Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();

            foreach (char c in charsInString)
            {
                if (keyValuePairs.ContainsKey(c))
                {
                    keyValuePairs[c]++;
                }
                else
                {
                    keyValuePairs.Add(c, 1);
                }
            }

            foreach (KeyValuePair<char, int> letter in keyValuePairs)
            {
                Console.WriteLine(letter.Key + " " + letter.Value);
            }
        }
    }
}