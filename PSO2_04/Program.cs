namespace PSO2_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any words:");
            string word = Console.ReadLine();
            string check = new string(word.Reverse().ToArray());

            if (word == check)
            {
                Console.WriteLine($"The word {word} is a palindrome.");
            }
            else
            {
                Console.WriteLine($"The word {word} is not a palindrome.");
            }
        }
    }
}
