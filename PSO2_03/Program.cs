namespace PSO2_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a Single Letter:");
            char letter = Console.ReadLine()[0];


            if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
            {
                Console.WriteLine($"Letter {letter} is a vowel.");

            }

            else if (char.IsLetter(letter))
            {
                Console.WriteLine($"Letter {letter} is a consonant.");
            }
            else
            {
                Console.WriteLine("Invalid. Please Enter A Single Letter Only.");
            }
        }
    }
}
