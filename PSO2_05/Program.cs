namespace PSO2_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter a Word: ");
            string word = Console.ReadLine();

            int[] number = new int[256];

            foreach (char c in word)
            {
                number[c]++;
            }


            Console.WriteLine("Number of Repetitions:");
            for (int x = 0; x < number.Length; x++)
            {
                if (number[x] > 0)
                {
                    Console.WriteLine($"{(char)x}: {number[x]}");
                }
            }
        }
    }
}

